using Microsoft.Extensions.Configuration;
using pfp_c.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace pfp_c.Services
{
    public class ProjetoService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;

        public ProjetoService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _baseUrl = configuration["ApiSettings:BaseUrl"] ?? throw new System.Exception("BaseUrl não configurada no appsettings.json");
        }
        public ProjetoService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<ProjetoDTO>> GetProjetosAsync()
        {
            var response = await _httpClient.GetAsync($"{_baseUrl}/projetos");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<ProjetoDTO>>();
        }

        public async Task<List<ProjetoDTO>> GetProjetosSemAtribuicaoAsync()
        {
            var response = await _httpClient.GetAsync($"{_baseUrl}/projetosSemAtribuicao");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<ProjetoDTO>>();
        }

        public async Task<List<ProjetoUrgenteDTO>> GetProjetosUrgentesAsync()
        {
            var response = await _httpClient.GetAsync($"{_baseUrl}/projetosUrgentes");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<ProjetoUrgenteDTO>>();
        }

        public async Task<List<ProjetoAtribuicaoDTO>> GetProjetosAtribuicaoAsync()
        {
            var response = await _httpClient.GetAsync($"{_baseUrl}/projetosAtribuicao");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<ProjetoAtribuicaoDTO>>();
        }

        public async Task<string> AddProjetoAsync(ProjetoDTO projeto, string login, string senha)
        {
            var response = await _httpClient.PostAsJsonAsync(
                $"{_baseUrl}/projetos?login={login}&senha={senha}", projeto);

            if (!response.IsSuccessStatusCode)
                return await response.Content.ReadAsStringAsync();

            return "Projeto cadastrado com sucesso!";
        }

        public async Task<string> UpdateProjetoAsync(long id, ProjetoDTO projeto)
        {
            var response = await _httpClient.PutAsJsonAsync($"{_baseUrl}/projetos?id={id}", projeto);
            if (!response.IsSuccessStatusCode)
                return await response.Content.ReadAsStringAsync();

            return "Projeto atualizado com sucesso!";
        }

        public async Task<string> AtribuirProjetoAsync(long idProjeto, long idFuncionario)
        {
            var response = await _httpClient.PutAsync(
                $"{_baseUrl}/projetosAtribuir?id={idProjeto}&func={idFuncionario}", null);

            if (!response.IsSuccessStatusCode)
                return await response.Content.ReadAsStringAsync();

            return "Projeto atribuído com sucesso!";
        }

        public async Task<string> DeleteProjetoAsync(long id)
        {
            var response = await _httpClient.DeleteAsync($"{_baseUrl}/projetos?id={id}");
            if (!response.IsSuccessStatusCode)
                return await response.Content.ReadAsStringAsync();

            return "Projeto excluído com sucesso!";
        }
    }
}
