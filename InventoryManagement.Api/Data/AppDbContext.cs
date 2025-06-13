using InventoryManagement.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Api.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Product>? Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("products");

            entity.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(200);
        });
    }
}
