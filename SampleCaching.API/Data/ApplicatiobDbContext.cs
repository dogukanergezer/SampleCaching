using Microsoft.EntityFrameworkCore;
using SampleCaching.API.Models;

namespace SampleCaching.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, FullName = "Doğukan Ergezer", Email = "dogukanergezer@gmail.com" },
                new Customer { Id = 2, FullName = "Doğancan Ergezer", Email = "dogancanergezer@gmail.com" });

        }
    }
}
