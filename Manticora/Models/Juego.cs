namespace Manticora.Models
{
    public class Juego
    {
        public NacionAtacante NacionAtacante { get; set; }
        public int  VidaManticora { get; set; }
        public int VidaCiudad { get; set; }
        public int RondaActual { get; set; }
        public string Estado { get; set; }
        public List<Defensor> Defensores { get; set; }
    }
}