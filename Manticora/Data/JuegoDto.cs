using Manticora.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Manticora.Data
{
    public class JuegoDto : Juego
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public NacionAtacanteDto NacionAtacante { get; set; }
        public int VidaManticora { get; set; }
        public int VidaCiudad { get; set; }
        public int RondaActual { get; set; }
        public string Estado { get; set; }
        public List<DefensorDto> Defensores { get; set; }
    }
}
