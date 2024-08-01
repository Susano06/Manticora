using Manticora.Data;
using Manticora.Models;

namespace Manticora.Services
{
    public interface IOperacionesDBService
    {
        Task GuardarJuegoAsync(JuegoDto juego);
        Task GuardarArmaAsync(Arma arma);
        Task GuardarDefensorAsync(Personaje personaje);
        Task<List<DefensorDto>> ObtenerDefensor();
        Task<List<ArmaDto>> ObtenerArma();
    }
}
