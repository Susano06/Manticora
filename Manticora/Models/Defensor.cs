﻿namespace Manticora.Models
{
    public class Defensor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Tipo { get; set; }
        public string Genero { get; set; }
        public List<Arma> Inventario { get; set; }
    }
}