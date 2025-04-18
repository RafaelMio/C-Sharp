using Microsoft.EntityFrameworkCore;
using StoreAPI.Models;

namespace StoreAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuration des propriétés et relations
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasPrecision(18, 2);

            // Données de démarrage
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "First Product",
                    Price = 19.99m,
                    Description = "This an example",
                    Quantity = 1
                }
            );
        }
    }
}
