using System.Net.Http;
using Microsoft.Extensions.Configuration;

namespace pfp_c.Services
{
    public abstract class ApiService
    {
        protected readonly HttpClient _httpClient;
        protected readonly string _baseUrl;

        public ApiService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _baseUrl = configuration["ApiSettings:BaseUrl"] ?? throw new Exception("BaseUrl não configurado");
        }
    }
}
