using Microsoft.EntityFrameworkCore;
using Pugcorn_v1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pugcorn_v1
{
    public class DbPugcornContext : DbContext
    {
        public DbPugcornContext(DbContextOptions<DbPugcornContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
