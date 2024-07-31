using Manticora.Models;
using Microsoft.EntityFrameworkCore;

namespace Manticora.Data
{
    public class JuegoContext : DbContext
    {
        public JuegoContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Personaje> Personajes { get; set; }
        public DbSet<Arma> Armas { get; set; }
        public DbSet<NacionAtacante> NacionesAtacantes { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite("Data Source=juego.db");
        //}
    }
}
