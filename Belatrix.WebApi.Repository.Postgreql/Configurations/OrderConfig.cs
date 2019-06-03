using Belatrix.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Belatrix.WebApi.Repository.Postgreql.Configurations
{
    internal class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("order");

            builder.Property(p => p.Id)
                .HasColumnName("id")
                .UseNpgsqlIdentityColumn();

            builder.Property(p => p.OrderDate)
                .HasColumnName("date")
                .IsRequired();

            builder.Property(p => p.OrderNumber)
                .HasColumnName("number")
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(p => p.TotalAmount)
                .HasColumnName("total_amount")
                .IsRequired();

            builder.HasIndex(e => new { e.CustomerId })
                .HasName("order_customer_id_idx");

            builder.HasIndex(e => new { e.OrderDate })
                .HasName("order_order_date_idx");
        }
    }
}
