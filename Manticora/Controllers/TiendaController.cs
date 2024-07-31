using Manticora.Models;
using Microsoft.AspNetCore.Mvc;

namespace Manticora.Controllers
{
	public class TiendaController : Controller
	{
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
		public IActionResult Comprar(Arma arma)
		{
			// Lógica para comprar el arma y agregarla al inventario del personaje
			return RedirectToAction("Index");
		}
	}
}
