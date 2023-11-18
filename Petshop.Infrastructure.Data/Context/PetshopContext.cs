using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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
        public DbSet<User> User { get; set; }

        public PetshopContext(DbContextOptions<PetshopContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(new UserMap().Configure);
        }
    }
}
