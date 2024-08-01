using Manticora.Models;
using System.ComponentModel.DataAnnotations;

namespace Manticora.Data
{
    public class DefensorDto
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Tipo { get; set; }
        public string Genero { get; set; }
        public List<ArmaDto> Inventario { get; set; }
    }
}
