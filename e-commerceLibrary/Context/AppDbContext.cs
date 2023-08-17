using Microsoft.EntityFrameworkCore;
using Task1_databaseConnect.Models;

namespace Task1_databaseConnect.e_commerceLibrary.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Customer> Customer { get; set; }

        //data seeding in category
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed initial categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Auto" },
                new Category { Id = 2, Name = "Beauty" },
                new Category { Id = 3, Name = "Books" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Laptop" , Price=123 ,CategoryId=1},
                new Product { Id = 2, Name = "Beauty", Price = 123, CategoryId = 2 },
                new Product { Id = 3, Name = "Books", Price = 123, CategoryId = 3 }
            );
        }

    }
}
