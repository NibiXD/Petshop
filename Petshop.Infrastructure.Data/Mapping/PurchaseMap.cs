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
    public class PurchaseMap : IEntityTypeConfiguration<Purchase>
    {
        public void Configure(EntityTypeBuilder<Purchase> builder)
        {
            builder.ToTable("purchase");

            builder.HasKey(p => p.ID);

            builder.HasOne(p => p.User)
                .WithMany()
                .HasForeignKey(p => p.UserId);

            builder.Property(p => p.UserId)
                .IsRequired()
                .HasColumnName("user_id")
                .HasColumnType("bigint");

            builder.Property(p => p.PaymentMethod)
                .IsRequired()
                .HasColumnName("payment_method")
                .HasColumnType("bigint");

            builder.Property(p => p.PurchaseDate)
                .IsRequired()
                .HasColumnName("purchase_date")
                .HasColumnType("date");

            builder.Property(p => p.TotalValue)
                .IsRequired()
                .HasColumnName("total_value")
                .HasColumnType("float");
        }
    }
}
