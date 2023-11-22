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
    public class AddressMap : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("address");

            builder.HasKey(k => k.ID);
            builder.HasOne(k => k.User)
                .WithMany()
                .HasForeignKey(k => k.UserId);

            builder.Property(k => k.UserId)
                .IsRequired()
                .HasColumnName("user_id")
                .HasColumnType("bigint");

            builder.Property(k => k.CEP)
                .HasConversion(k => k.ToString(), k => k)
                .IsRequired()
                .HasColumnName("cep")
                .HasColumnType("text");

            builder.Property(k => k.City)
                .HasConversion(k => k.ToString(), k => k)
                .IsRequired()
                .HasColumnName("city")
                .HasColumnType("text");

            builder.Property(k => k.Street)
                .HasConversion(k => k.ToString(), k => k)
                .IsRequired()
                .HasColumnName("street")
                .HasColumnType("text");

            builder.Property(k => k.Number)
                .IsRequired()
                .HasColumnName("number")
                .HasColumnType("bigint");
        }
    }
}
