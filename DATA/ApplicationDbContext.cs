using __P01_SalesDatabase.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __P01_SalesDatabase.DATA
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=SalesDatabase;Integrated Security=True;" +
                "TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().Property(e => e.Name).IsRequired().HasMaxLength(50).IsUnicode(true);
            modelBuilder.Entity<Customer>().Property(e => e.Name).IsRequired().HasMaxLength(100).IsUnicode(true);
            modelBuilder.Entity<Customer>().Property(e => e.Email).IsRequired().HasMaxLength(80).IsUnicode(false);
            modelBuilder.Entity<Store>().Property(e => e.StoreName).IsRequired().HasMaxLength(80).IsUnicode();

           
        }
        

    }
}
