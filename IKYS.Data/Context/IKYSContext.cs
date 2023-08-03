using IKYS.Data.Mapping;
using IKYS.Domain.Abstract;
using IKYS.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKYS.Data.Context
{
    public class IKYSContext : DbContext
    {
        DbSet<Buy> Buys { get; set; }
        DbSet<Chef> Chefs { get; set; }
        DbSet<Finance> Finances { get; set;}
        DbSet<ProjectManager> ProjectManagers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=IKYSData;Trusted_Connection=True;TrustServerCertificate=True");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new PersonelBase());
            modelBuilder.ApplyConfiguration(new BuyMapping());
            modelBuilder.ApplyConfiguration(new ChefMapping());
            modelBuilder.ApplyConfiguration(new FinanceMapping());
            modelBuilder.ApplyConfiguration(new ProjectManagerMapping());
        }
    }
}
