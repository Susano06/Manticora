using Manticora.Services;
using Microsoft.AspNetCore.Mvc;
using Manticora.Models;

namespace Manticora.Controllers
{
    public class JuegoController : Controller
    {
        private readonly IRickAndMortyApiService _rickAndMortyApiService;

        public JuegoController(IRickAndMortyApiService rickAndMortyApiService)
        {
            _rickAndMortyApiService = rickAndMortyApiService;
        }

        public async Task<IActionResult> IniciarJuego()
        {
            var nacionAtacante = await _rickAndMortyApiService.ObtenerNacionAtacante();
            var mantícora = new Manticoras { Vida = 10 };
            var ciudad = new Ciudad { Vida = 15 };

            var juego = new Juego
            {
                NacionAtacante = nacionAtacante,
                Manticora = mantícora,
                Ciudad = ciudad,
                RondaActual = 1,
                Estado = "Iniciado"
            };

            // Guardar el estado inicial del juego en la base de datos
            // ...

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
