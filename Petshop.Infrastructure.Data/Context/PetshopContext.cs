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
        public DbSet<Address> Address { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<CreditCard> CreditCard { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductType> ProductType { get; set; }
        public DbSet<Purchase> Purchase { get; set; }
        public DbSet<PurchaseProduct> PurchaseProduct { get; set; }

        public PetshopContext(DbContextOptions<PetshopContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(new UserMap().Configure);
            modelBuilder.Entity<Address>(new AddressMap().Configure);
            modelBuilder.Entity<Cart>(new CartMap().Configure);
            modelBuilder.Entity<CreditCard>(new CreditCardMap().Configure);
            modelBuilder.Entity<Product>(new ProductMap().Configure);
            modelBuilder.Entity<ProductType>(new ProductTypeMap().Configure);
            modelBuilder.Entity<Purchase>(new PurchaseMap().Configure);
            modelBuilder.Entity<PurchaseProduct>(new PurchaseProductMap().Configure);
        }
    }
}
