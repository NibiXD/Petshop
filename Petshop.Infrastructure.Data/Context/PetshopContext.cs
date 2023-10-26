using Microsoft.EntityFrameworkCore;
using Petshop.Domain.Entities;
using Petshop.Infrastructure.Data.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Infrastructure.Data.Context
{
    public class PetshopContext : DbContext
    {
        public DbSet<User> MyProperty { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(
                "Server=localhost;" +
                "Port=5432;Database=petshop;" +
                "User Id=postgres;" +
                "Password=postgres;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(new UserMap().Configure);
        }
    }
}
