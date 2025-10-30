using Microsoft.Extensions.Configuration;
using pfp_c.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace pfp_c.Services
{
    public class FuncionarioService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;

        public FuncionarioService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _baseUrl = configuration["ApiSettings:BaseUrl"] ?? throw new System.Exception("BaseUrl não configurada no appsettings.json");
        }

        public async Task<List<Funcionario>> ListarFuncionariosAsync()
        {
            var url = $"{_baseUrl}/funcionarios"; // Endpoint do seu controller
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            // Converte o JSON da API para uma lista de objetos Funcionario
            var funcionarios = await response.Content.ReadFromJsonAsync<List<Funcionario>>();
            return funcionarios ?? new List<Funcionario>();
        }

        public async Task<Funcionario?> BuscarFuncionarioPorIdAsync(long id)
        {
            var response = await _httpClient.GetAsync($"{_baseUrl}/funcionarioid?id={id}");
            response.EnsureSuccessStatusCode();
            var funcionario = await response.Content.ReadFromJsonAsync<Funcionario>();
            return funcionario ?? new Funcionario();
        }

        public async Task<string> CriarFuncionarioAsync(Funcionario funcionario)
        {
            var response = await _httpClient.PostAsJsonAsync($"{_baseUrl}/funcionarios", funcionario);
            var resposta = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
                return resposta; // Deve vir "Ok"
            else
                throw new System.Exception($"Erro: {resposta}");
        }
        public async Task<string> AtualizarFuncionarioAsync(long id, Funcionario funcionario)
        {
            var response = await _httpClient.PutAsJsonAsync($"{_baseUrl}funcionarios?id={id}", funcionario);
            var resultado = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
                return resultado; 
            else
                throw new Exception($"Erro ao atualizar funcionário: {resultado}");
        }
        public async Task<string> DeletarFuncionarioAsync(long id)
        {
            var response = await _httpClient.DeleteAsync($"{_baseUrl}funcionarios?id={id}");
            var resultado = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
                return resultado;
            else
                throw new Exception($"Erro ao excluir funcionário: {resultado}");
        }
    }
}
