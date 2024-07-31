namespace Manticora.Models
{
    public class PersonajesViewModel
    {
        public List<Personaje> Personajes { get; set; }
        public int PaginaActual { get; set; }
        public int TotalPaginas { get; set; }
        public string? NombreFiltro { get; set; }
    }
}
