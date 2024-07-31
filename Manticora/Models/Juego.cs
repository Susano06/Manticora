namespace Manticora.Models
{
    public class Juego
    {
        public NacionAtacante NacionAtacante { get; set; }
        public Manticoras Manticora { get; set; }
        public Ciudad Ciudad { get; set; }
        public int RondaActual { get; set; }
        public string Estado { get; set; }
        public List<Defensor> Defensores { get; set; }
    }
}