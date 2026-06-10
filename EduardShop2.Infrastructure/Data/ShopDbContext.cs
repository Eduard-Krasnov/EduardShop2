using EduardShop2.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EduardShop2.Infrastructure.Data;

public class ShopDbContext : DbContext
{
    public ShopDbContext(DbContextOptions<ShopDbContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Products => Set<Product>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .Property(p => p.Price)
            .HasPrecision(18, 2);

        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Milk", Price = 2.50m },
            new Product { Id = 2, Name = "Bread", Price = 1.20m },
            new Product { Id = 3, Name = "Apple", Price = 0.80m }
        );
    }
}