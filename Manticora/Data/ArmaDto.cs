using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Manticora.Models;

namespace Manticora.Data
{
    public class ArmaDto : Arma
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int PersonajeId { get; set; } // Clave foránea
        public DefensorDto Personaje { get; set; } // Navegación inversa
    }
}
