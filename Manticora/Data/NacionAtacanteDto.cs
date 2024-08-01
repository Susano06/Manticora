using Manticora.Models;
using System.ComponentModel.DataAnnotations;

namespace Manticora.Data
{
    public class NacionAtacanteDto
    {
        [Key]
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Tipo { get; set; }
        public string? Dimension { get; set; }
        public int Habitantes { get; set; }
    }
}
