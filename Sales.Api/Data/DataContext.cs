using Microsoft.EntityFrameworkCore;
using Sales.Shared.Entities;

namespace Sales.Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Country> Countries { get; set; }
        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>().HasIndex(x => x.Name).IsUnique();
            modelBuilder.Entity<Country>().HasData(
                new Country { Id = 1, Name = "Venezuela" },
                new Country { Id = 2, Name = "Estados Unidos" },
                new Country { Id = 3, Name = "Mexico" }
            );
        }
    }
}