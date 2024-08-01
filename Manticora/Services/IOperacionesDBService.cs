using Manticora.Models;

namespace Manticora.Services
{
    public interface IOperacionesDBService
    {
        Task GuardarJuegoAsync(Juego juego);
        Task GuardarArmaAsync(Arma arma);
    }
}
