using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.Contexts
{
    public class MusteriPersonelTasimaAppContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=HUSEYIN\SQLEXPRESS;Database=MusteriPersonelTasimaApp;Trusted_Connection=true");
        }
              

        public DbSet<Arac> Aracs { get; set; }
        public DbSet<Guzergah> Guzergahs { get; set; }
        public DbSet<Sofor> Sofors { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Arac>().ToTable("Araclar");
            modelBuilder.Entity<Guzergah>().ToTable("Guzergahlar");
            modelBuilder.Entity<Sofor>().ToTable("Soforler");
        }
    }
}
