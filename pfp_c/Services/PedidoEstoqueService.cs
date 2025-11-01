using pfp_c.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;


namespace pfp_c.Services
{
    public class PedidoEstoqueService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;

        public PedidoEstoqueService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _baseUrl = configuration["ApiSettings:BaseUrl"] ?? throw new System.Exception("BaseUrl não configurada no appsettings.json");

        }

        public async Task<List<PedidoEstoqueDTO>> GetPedidosAsync()
        {
            var response = await _httpClient.GetAsync($"{_baseUrl}/pedidoEstoque");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<PedidoEstoqueDTO>>();
        }

        public async Task<List<PedidoEstoqueProjetoDTO>> GetPedidosPorProjetoAsync(long id)
        {
            var response = await _httpClient.GetAsync($"{_baseUrl}/pedidoEstoqueProj?id={id}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<PedidoEstoqueProjetoDTO>>();
        }

        public async Task<string> AddPedidoAsync(PedidoEstoqueDTO pedido, string login, string senha)
        {
            var response = await _httpClient.PostAsJsonAsync(
                $"{_baseUrl}/pedidoEstoque?login={login}&senha={senha}", pedido);

            if (!response.IsSuccessStatusCode)
                return await response.Content.ReadAsStringAsync();

            return "Pedido de estoque cadastrado com sucesso!";
        }

        public async Task<string> UpdatePedidoAsync(long id, PedidoEstoqueDTO pedido)
        {
            var response = await _httpClient.PutAsJsonAsync($"{_baseUrl}/pedidoEstoque?id={id}", pedido);

            if (!response.IsSuccessStatusCode)
                return await response.Content.ReadAsStringAsync();

            return "Pedido de estoque atualizado com sucesso!";
        }

        public async Task<string> DeletePedidoAsync(long id)
        {
            var response = await _httpClient.DeleteAsync($"{_baseUrl}/pedidoEstoque?id={id}");

            if (!response.IsSuccessStatusCode)
                return await response.Content.ReadAsStringAsync();

            return "Pedido de estoque excluído com sucesso!";
        }
    }
}
