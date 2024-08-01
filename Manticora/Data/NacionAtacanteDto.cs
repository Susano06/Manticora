using Manticora.Models;
using System.ComponentModel.DataAnnotations;

namespace Manticora.Data
{
    public class NacionAtacanteDto: NacionAtacante
    {
        [Key]
        public int Id { get; set; }
    }
}
