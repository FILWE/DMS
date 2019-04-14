using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DMS.Models;

namespace DMS.Data
{
    public class DMSContext : DbContext
    {
        public DMSContext (DbContextOptions<DMSContext> options)
            : base(options)
        {
        }

        public DbSet<DMS.Models.Delivery> Deliveries { get; set; }

        public DbSet<DMS.Models.Shop> Shops { get; set; }

        public DbSet<DMS.Models.Stock> Stocks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Delivery>().ToTable("Delivery");
            modelBuilder.Entity<Shop>().ToTable("Shop");
            modelBuilder.Entity<Stock>().ToTable("Stock");
        }
    }
}
