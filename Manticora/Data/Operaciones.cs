using Manticora.Models;
using Manticora.Services;

namespace Manticora.Data
{
    public class Operaciones : IOperacionesDBService
    {
        private readonly JuegoContext _context;

        public Operaciones(JuegoContext context) => _context = context;

        public async Task GuardarJuegoAsync(Juego juego)
        {

            var juegoDto = new JuegoDto
            {
                NacionAtacante = (NacionAtacanteDto)juego.NacionAtacante,
                VidaManticora = juego.VidaManticora,
                VidaCiudad = juego.VidaCiudad,
                RondaActual = juego.RondaActual,
                Estado = juego.Estado
            };

            _context.Juegos.Add(juegoDto);
            await _context.SaveChangesAsync();
        }

        public async Task GuardarArmaAsync(Arma arma)
        {

            var armaDto = new ArmaDto
            {
                Nombre = arma.Nombre,
                Costo = arma.Costo,
                Alcance = arma.Alcance
            };
            _context.Armas.Add(armaDto);
            await _context.SaveChangesAsync();
        }
    }
}
