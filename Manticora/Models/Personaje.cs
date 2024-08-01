using Manticora.Data;

namespace Manticora.Models
{
    public class Personaje
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Especie { get; set; }
        public string? Tipo { get; set; }
        public string? Genero { get; set; }
        public string? ImagenUrl { get; set; }
        public int Oro { get; set; } = 100;
    }

}
