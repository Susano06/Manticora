using Manticora.Models;
using Microsoft.EntityFrameworkCore;

namespace Manticora.Data
{
    public class JuegoContext : DbContext
    {
        public JuegoContext(DbContextOptions options) : base(options)
        {
        }

        //public DbSet<Personaje> Personajes { get; set; }
        public DbSet<ArmaDto> Armas { get; set; }
        
        //public DbSet<NacionAtacante> NacionesAtacantes { get; set; }
        public DbSet<JuegoDto> Juegos { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<Personaje>()
        //        .HasMany(p => p.Inventario)
        //        .WithOne(a => a.Personaje)
        //        .HasForeignKey(a => a.PersonajeId);

        //    // Configuración adicional si es necesario
        //}

    }
}
