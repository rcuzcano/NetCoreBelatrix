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

            builder.Property(p => p.CustomerId)
                .HasColumnName("id")
                .IsRequired();

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

        }
    }
}
