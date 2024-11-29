using Microsoft.EntityFrameworkCore;
using server.Database.Models;

namespace server.Database
{
    public class OgotaContext : DbContext
    {
        public OgotaContext(DbContextOptions<OgotaContext> option) : base (option)
        {
        }

        public DbSet <Product> Products { get; set; }
        public DbSet <Customer> Customers { get; set; }
        public DbSet <Admin> Admins { get; set; }
        public DbSet <OrderHistory> OrderHistories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ogota.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

                modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 1,
                        ProductName = "Programmering Grund 1",
                        ProductDescription = "Lär dig grunderna i programmering",
                        Price = 500,
                        Stock = 30,
                        Location = "Distans",
                        CreatedAt = new DateOnly(2021, 10, 10),
                        UpdatedAt = new DateOnly(2021, 10, 10)
                    },
                    new Product
                    {
                        Id = 2,
                        ProductName = "HTML",
                        ProductDescription = "Lär dig mer om HTML",
                        Price = 1000,
                        Stock = 30,
                        Location = "Distans",
                        CreatedAt = new DateOnly(2022, 10, 10),
                        UpdatedAt = new DateOnly(2022, 10, 10)
                    });
        }
    }
}
