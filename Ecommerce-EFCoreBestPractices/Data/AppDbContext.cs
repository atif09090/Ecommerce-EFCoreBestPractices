using Ecommerce_EFCoreBestPractices.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_EFCoreBestPractices.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<Order> Orders => Set<Order>();
        public DbSet<Product> Products => Set<Product>();
        public DbSet<OrderItem> OrderItems => Set<OrderItem>();

        public AppDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .HasDatabaseName("IX_Users_Email");

            modelBuilder.Entity<Order>()
                .HasIndex(o => o.CreatedAt);
        }
    }

}
