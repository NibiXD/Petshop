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
    public class CartMap : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("cart");

            builder.HasKey(c => new { c.ProductId, c.UserId });

            builder.HasOne(c => c.User)
                .WithMany()
                .HasForeignKey(c => c.UserId);

            builder.HasOne(c => c.Product)
                .WithMany()
                .HasForeignKey(c => c.ProductId);

            builder.Property(c => c.UserId)
                .IsRequired()
                .HasColumnName("user_id")
                .HasColumnType("bigint");

            builder.Property(c => c.ProductId)
                .IsRequired()
                .HasColumnName("product_id")
                .HasColumnType("bigint");
        }
    }
}
