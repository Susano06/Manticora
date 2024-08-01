using Manticora.Data;
using Manticora.Models;

namespace Manticora.Services
{
    public interface IRickAndMortyApiService
    {
        Task<ApiResponse> ObtenerPersonajes(string nombre = "", int pagina = 1);
        Task<NacionAtacanteDto> ObtenerNacionAtacante();

	}
}
