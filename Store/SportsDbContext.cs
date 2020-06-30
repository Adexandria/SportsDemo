using Microsoft.EntityFrameworkCore;
using Store.Models;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace Store
{
    public class SportsDbContext :DbContext
    {
        public SportsDbContext(DbContextOptions<SportsDbContext>options):base(options)
        {

        }
        public DbSet<Details> Details { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
