using Belatrix.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Belatrix.WebApi.Repository.Postgreql.Configurations
{
    internal class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("product");

            builder.Property(p => p.Id)
                .HasColumnName("id")
                .IsRequired();

            builder.Property(p => p.ProductName)
                .HasColumnName("name")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(p => p.UnitPrice)
                .HasColumnName("unit_price")
                .IsRequired();

            builder.Property(p => p.Package)
                .HasColumnName("package")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(p => p.IsDiscontinued)
                .HasColumnName("is_discontinued")
                .IsRequired();

            builder.HasIndex(e => new { e.SupplierId })
                .HasName("product_supplier_id_idx");

            builder.HasIndex(e => new { e.ProductName })
                .HasName("product_name_idx");
        }
    }
}
