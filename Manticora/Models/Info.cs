namespace Manticora.Models
{
    public class Info
    {
        public long Count { get; set; }
        public int Pages { get; set; }
        public Uri? Next { get; set; }
        public Uri?  Prev { get; set; }
    }
}
