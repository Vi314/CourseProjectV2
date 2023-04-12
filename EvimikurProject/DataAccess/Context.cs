using Entity.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace DataAccess
{
    public class Context:IdentityDbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) {}

        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Dealer> Dealers { get; set; }
        public DbSet<DealerStocks> DealerStocks { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //EMPLOYEE
            builder.Entity<Employee>()
                .HasOne(d => d.District)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            //ORDER DETAILS
            builder.Entity<OrderDetails>()
                .HasOne(p => p.Product)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            base.OnModelCreating(builder);
        }

    }
}