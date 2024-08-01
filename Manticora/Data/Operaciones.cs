using Manticora.Models;
using Manticora.Services;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Security.Principal;

namespace Manticora.Data
{
    public class Operaciones : IOperacionesDBService
    {
        private readonly JuegoContext _context;

        public Operaciones(JuegoContext context) => _context = context;

        public async Task GuardarJuegoAsync(JuegoDto juego)
        {
            _context.Juegos.Add(juego);
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

        public async Task GuardarDefensorAsync(Personaje personaje)
        {
            var defensor = new DefensorDto
            {
                Id = personaje.Id,
                Nombre = personaje.Nombre,
                Genero = personaje.Genero,
                Especie = personaje.Especie,
                Tipo = personaje.Tipo
            };
            _context.Defensores.Add(defensor);
            await _context.SaveChangesAsync();
        }

        public async Task<List<DefensorDto>> ObtenerDefensor()
        {
            var defensores = await _context.Defensores.ToListAsync();
            var armas = await ObtenerArma();


            foreach (var item in defensores)
            {
                foreach (var gun in armas)
                {
                    item.Inventario = new List<ArmaDto>() { 
                        new ArmaDto { 
                            
                            //Id = gun.Id,
                            Nombre = gun.Nombre,
                            Alcance = gun.Alcance,
                            Costo = gun.Costo                            
                        } 
                    } ;
                }
            }

            return defensores;
        }

        public async Task<List<ArmaDto>> ObtenerArma()
        {
            var armas = await _context.Armas.ToListAsync();
            return armas;
        }
    }
}
