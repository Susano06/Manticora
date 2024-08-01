using Manticora.Services;
using Microsoft.AspNetCore.Mvc;
using Manticora.Models;
using Manticora.Data;

namespace Manticora.Controllers
{
    public class JuegoController : Controller
    {
        private readonly IRickAndMortyApiService _rickAndMortyApiService;
        private readonly IOperacionesDBService _operacionesDBService;

        public JuegoController(IRickAndMortyApiService rickAndMortyApiService, IOperacionesDBService operacionesDBService)
        {
            _rickAndMortyApiService = rickAndMortyApiService;
            _operacionesDBService = operacionesDBService;
        }

        public async Task<IActionResult> IniciarJuego()
        {
            var nacionAtacante = await _rickAndMortyApiService.ObtenerNacionAtacante();

            var juego = new Juego
            {
                NacionAtacante = nacionAtacante,
                VidaManticora = 10,
                VidaCiudad = 15,
                RondaActual = 1,
                Estado = "Iniciado"
            };

            //// Guardar el estado inicial del juego en la base de datos
            await _operacionesDBService.GuardarJuegoAsync(juego);

            return View(juego);
        }

        [HttpPost]
        public IActionResult Disparar(int idPersonaje, string armaNombre)
        {
            // Lógica para realizar un disparo y actualizar el estado del juego
            // ...

            return RedirectToAction("IniciarJuego");
        }
    }
}
