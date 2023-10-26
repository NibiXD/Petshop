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
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.HasKey(k => k.ID);
            builder.Property(k => k.Name)
                .HasConversion(k => k.ToString(), k => k)
                .IsRequired()
                .HasColumnName("name")
                .HasColumnType("text");
            builder.Property(k => k.Email)
                .HasConversion(k => k.ToString(), k => k)
                .IsRequired()
                .HasColumnName("email")
                .HasColumnType("text");
            builder.Property(k => k.Password)
                .HasConversion(k => k.ToString(), k => k)
                .IsRequired()
                .HasColumnName("password")
                .HasColumnType("text");
        }
    }
}
