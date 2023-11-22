using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Petshop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Infrastructure.Data.Mapping
{
    public class PurchaseProductMap : IEntityTypeConfiguration<PurchaseProduct>
    {
        public void Configure(EntityTypeBuilder<PurchaseProduct> builder)
        {
            builder.ToTable("purchase_product");

            builder.HasKey(p => new { p.ProductId, p.PurchaseId });

            builder.HasOne(p => p.Product)
                .WithMany()
                .HasForeignKey(p => p.ProductId);

            builder.HasOne(p => p.Purchase)
                .WithMany()
                .HasForeignKey(p => p.PurchaseId);
        }
    }
}
