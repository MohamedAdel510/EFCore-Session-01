using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task02.Configurations;
using Task02.Entities;

namespace Task02.Contexts
{
    public class EnterPriseDbContext02:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = MOHAMMED; Database = Task02; Trusted_Connection = true; TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee02>()
                .Property(P => P.Name)
                .HasDefaultValue("Test")
                .IsRequired(false);

            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
        }
        public DbSet<Employee02> Employees { get; set; }
        public DbSet<Department02> Departments { get; set; }
        public DbSet<Product> Pproducts { get; set; }
        public DbSet<Project> Projects { get; set; }
    }
}
