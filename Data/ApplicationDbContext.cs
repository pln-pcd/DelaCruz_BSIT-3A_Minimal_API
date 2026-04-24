using Microsoft.EntityFrameworkCore;
using ProductApi.Models; // Ensure this matches your project folder name

namespace ProductApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // The DbSets tell EF Core to create tables for these models
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // This is the specific connection string that works on your Mac/Docker setup
                optionsBuilder.UseSqlServer("Server=localhost,1433;Database=ProductManagementDB;User Id=SA;Password=PM123;Integrated Security=False;TrustServerCertificate=True;");
            }
        }
    }
}