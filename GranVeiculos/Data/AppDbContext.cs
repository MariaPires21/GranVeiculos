using Microsoft.EntityFrameworkCore;

namespace GranVeiculos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Models.Veiculo> Veiculos { get; set; }
        public DbSet<Models.Modelo> Modelos { get; set; }
        public DbSet<Models.Marca> Marcas { get; set; }
        public DbSet<Models.Cor> Cores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Veiculo>()
                .Property(v => v.Valor)
                .HasColumnType("numeric(10,2)");
        }
    }
}