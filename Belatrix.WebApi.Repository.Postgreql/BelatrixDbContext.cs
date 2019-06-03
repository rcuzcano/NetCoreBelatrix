using Belatrix.WebApi.Models;
using Belatrix.WebApi.Repository.Postgreql.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Belatrix.WebApi.Repository.Postgreql
{
    public class BelatrixDbContext : DbContext
    {
        public BelatrixDbContext(DbContextOptions<BelatrixDbContext> opt) 
            : base (opt)
        {
            
        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Customer> Order { get; set; }

        public DbSet<Customer> OrderItem { get; set; }

        public DbSet<Customer> Product { get; set; }

        public DbSet<Customer> Supplier { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfig());
        }
    }
}
