using Manticora.Models;
using Manticora.Services;
using Microsoft.AspNetCore.Mvc;

namespace Manticora.Controllers
{
	public class TiendaController : Controller
	{
        private readonly IOperacionesDBService _operacionesDBService;

        public TiendaController(IOperacionesDBService operacionesDBService)
        {
            _operacionesDBService = operacionesDBService;
        }
        public IActionResult Index()
		{
			var armas = new List<Arma>
		{
			new Arma { Nombre = "Gran cañón", Costo = 80, Alcance = 50 },
			new Arma { Nombre = "Metralla", Costo = 60, Alcance = 40 },
			new Arma { Nombre = "Mosquete", Costo = 50, Alcance = 30 },
			new Arma { Nombre = "Pistola", Costo = 30, Alcance = 20 },
			new Arma { Nombre = "Granada", Costo = 10, Alcance = 10 }
		};
			return View(armas);
		}

		[HttpPost]
		public async Task<IActionResult> Comprar(Arma arma)
		{
            // Lógica para comprar el arma y agregarla al inventario del personaje
            await _operacionesDBService.GuardarArmaAsync(arma);

            return RedirectToAction("Index");
		}
	}
}
