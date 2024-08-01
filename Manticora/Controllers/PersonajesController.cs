using Manticora.Models;
using Manticora.Services;
using Microsoft.AspNetCore.Mvc;

namespace Manticora.Controllers
{
    public class PersonajesController : Controller
    {
        private readonly IRickAndMortyApiService _rickAndMortyApiService;
        private readonly IOperacionesDBService _operacionesDBService;

        public PersonajesController(IRickAndMortyApiService rickAndMortyApiService, IOperacionesDBService operacionesDBService)
        {
            _rickAndMortyApiService = rickAndMortyApiService;
            _operacionesDBService = operacionesDBService;
        }

        public async Task<IActionResult> Index(string nombre = "", int pagina = 1)
        {
            var response = await _rickAndMortyApiService.ObtenerPersonajes(nombre, pagina);
            var viewModel = new PersonajesViewModel
            {
                Personajes = response.Results.Select(r => new Personaje
                {
                    Id = r.Id,
                    Nombre = r.Name,
                    Especie = r.Species,
                    Tipo = r.Type,
                    Genero = r.Gender,
                    ImagenUrl = r.Image
                }).ToList(),
                PaginaActual = pagina,
                TotalPaginas = response.Info.Pages,
                NombreFiltro = nombre
            };

            return View(viewModel);
        }

        public async Task<IActionResult> Detalle(int id, string nombre)
        {
            var response = await _rickAndMortyApiService.ObtenerPersonajes(nombre);
            var personajeList = response.Results.Select(r => new Personaje
            {
                Id = r.Id,
                Nombre = r.Name,
                Especie = r.Species,
                Tipo = r.Type,
                Genero = r.Gender,
                ImagenUrl = r.Image
            }).ToList();
            var personaje = personajeList.FirstOrDefault(p => p.Id == id);
            if (personaje == null) return NotFound();
            return View(personaje);
        }

        [HttpPost]
        public async Task<IActionResult> SeleccionarPersonaje(Personaje personaje)
        {
            await _operacionesDBService.GuardarDefensorAsync(personaje);

            return RedirectToAction("Index");
        }
    }
}