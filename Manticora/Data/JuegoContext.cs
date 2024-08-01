using Manticora.Models;
using Microsoft.EntityFrameworkCore;

namespace Manticora.Data
{
    public class JuegoContext : DbContext
    {
        public JuegoContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<DefensorDto> Defensores { get; set; }
        public DbSet<ArmaDto> Armas { get; set; }        
        public DbSet<NacionAtacanteDto> NacionesAtacantes { get; set; }
        public DbSet<JuegoDto> Juegos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DefensorDto>()
                .HasMany(p => p.Inventario)
                .WithOne(a => a.Personaje)
                .HasForeignKey(a => a.PersonajeId);

            modelBuilder.Entity<JuegoDto>()
                .HasMany(p => p.Defensores)
                .WithOne(a => a.Juego)
                .HasForeignKey(a => a.IdJuego);
        }

    }
}
