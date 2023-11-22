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
    public class CreditCardMap : IEntityTypeConfiguration<CreditCard>
    {
        public void Configure(EntityTypeBuilder<CreditCard> builder)
        {
            builder.ToTable("credit_card");

            builder.HasKey(c => c.ID);

            builder.HasOne(c => c.User)
                .WithMany()
                .HasForeignKey(c => c.UserId);

            builder.Property(c => c.UserId)
                .IsRequired()
                .HasColumnName("user_id")
                .HasColumnType("bigint");

            builder.Property(c => c.Name)
                .IsRequired()
                .HasColumnName("name")
                .HasColumnType("text");

            builder.Property(c => c.Number)
                .IsRequired()
                .HasColumnName("number")
                .HasColumnType("text");
            
            builder.Property(c => c.ExpireDate)
                .IsRequired()
                .HasColumnName("expire_date")
                .HasColumnType("date");

            builder.Property(c => c.CVV)
                .IsRequired()
                .HasColumnName("cvv")
                .HasColumnType("bigint");
        }
    }
}
