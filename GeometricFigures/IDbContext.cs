using GeometricFigures.Models;
using Microsoft.EntityFrameworkCore;

namespace GeometricFigures
{
    public class GeometricFiguresDbContext : DbContext
    {
       public DbSet<Product> Products { get; set; }
       public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                    .HasMany(c => c.Categories)
                    .WithMany(s => s.Products)
                    .UsingEntity(j => j.ToTable("ProductCategory"));
        }
    }
}
