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
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("product");

            builder.HasKey(p => p.ID);

            builder.HasOne(p => p.ProductType)
                .WithMany()
                .HasForeignKey(p => p.ProductTypeId);

            builder.Property(p => p.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("text");

            builder.Property(p => p.ProductTypeId)
                .IsRequired()
                .HasColumnName("product_type")
                .HasColumnType("bigint");

            builder.Property(p => p.Price)
                .IsRequired()
                .HasColumnName("price")
                .HasColumnType("float");

            builder.Property(p => p.QuantityInStock)
                .IsRequired()
                .HasColumnName("quantity_in_stock")
                .HasColumnType("bigint");
        }
    }
}
