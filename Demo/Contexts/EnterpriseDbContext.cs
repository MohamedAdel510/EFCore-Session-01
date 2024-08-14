using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Configurations;
using Demo.Entities;
using EFCoreFluntAPIS;
using Microsoft.EntityFrameworkCore;

namespace Demo.Contexts
{
    internal class EnterpriseDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // .net framework
            //optionsBuilder.UseSqlServer("Data source = MOHAMMED; Intial catalog = EnterpriseEFCoreS01; User = Mohamed; Password = 123")
            
            //.net framework core
            optionsBuilder.UseSqlServer("Server = MOHAMMED; Database = EnterpriseEFCoreS01; Trusted_Connection = true; TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent APIs
            modelBuilder.Entity<Employee>()
                .Property(E => E.Name)
                .HasDefaultValue("Test")
                .IsRequired(false);

            #region To set class as table to database
            //modelBuilder.Entity<Department>().ToTable("Departments");
            // note that use DbSet is better
            #endregion

            #region Department Configurations Before
            //modelBuilder.Entity<Department>()
            //    .HasKey(D => D.DeptId);

            //modelBuilder.Entity<Department>()
            //    .Property(D => D.DeptId)
            //    .UseIdentityColumn(10, 10);

            //modelBuilder.Entity<Department>()
            //    .Property(D => D.Name)
            //    .HasColumnName("DeptName")
            //    .HasColumnType("varchar")
            //    .HasMaxLength(50);
            #endregion

            #region Department Configurations After 
            // EFCore 3.1 Feture
            //modelBuilder.Entity<Department>(E =>
            //{
            //   E.HasKey(D => D.DeptId);

            //   E.Property(D => D.DeptId)
            //    .UseIdentityColumn(10, 10);

            //   E.Property(D => D.Name)
            //    .HasColumnName("DeptName")
            //    .HasColumnType("varchar")
            //    .HasMaxLength(50);
            //});
            #endregion

            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
