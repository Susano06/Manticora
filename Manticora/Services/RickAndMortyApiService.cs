using Manticora.Models;
using System.Net.Http;

namespace Manticora.Services
{
    public class RickAndMortyApiService : IRickAndMortyApiService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _Configuration;

        public RickAndMortyApiService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _Configuration = configuration;
        }

        public async Task<NacionAtacante> ObtenerNacionAtacante()
        {
            var response = await _httpClient.GetAsync($"{_Configuration["Rickandmortyapi"]}location/");
			response.EnsureSuccessStatusCode();
			var data = await response.Content.ReadAsAsync<ApiLocationResponse>();
            var location = data?.Results?[new Random().Next(data.Results.Count)];
            return new NacionAtacante
            {
                Nombre = location?.Name,
                Tipo = location?.Type,
                Dimension = location?.Dimension,
                Habitantes = location.Residents.Count
            };
        }

        public async Task<ApiResponse> ObtenerPersonajes(string nombre = "", int pagina = 1)
        {
            var response = await _httpClient.GetAsync($"{_Configuration["Rickandmortyapi"]}character/?name={nombre}&page={pagina}");
            response.EnsureSuccessStatusCode();
            var data = await response.Content.ReadAsAsync<ApiResponse>();
            return data;            
        }
    }
}
