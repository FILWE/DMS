using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DMS.Models;

namespace DMS.Models
{
    public class DMSContext : DbContext
    {
        public DMSContext (DbContextOptions<DMSContext> options)
            : base(options)
        {
        }

        public DbSet<DMS.Models.Delivery> Delivery { get; set; }

        public DbSet<DMS.Models.Shop> Shop { get; set; }

        public DbSet<DMS.Models.Stock> Stock { get; set; }
    }
}
