using System;
using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using PassoutASP.Models;

namespace PassoutASP.Services
{
    public class PassoutContext : DbContext
    {
        // .NET CLI
        // dotnet ef migrations add [Nombre de migracion]
        // dotnet ef database update

        // public virtual DbSet<ObjectClass> Object { get; set; }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Employe> Employes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
#if DEBUG
            optionsBuilder.UseMySQL("server=localhost; port=3306; database=Passout-DEBUG; user=root; password=Ragnarok1");
#else
            optionsBuilder.UseMySQL("server=localhost; port=3306; database=Passout-PROD; user=root; password=Ragnarok1");
#endif
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Employe>().ToTable("Employes");
            // modelBuilder.Entity<ObjectClass>().ToTable("TableName");
        }
    }
}
