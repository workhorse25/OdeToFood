using Microsoft.EntityFrameworkCore;
using SargentRF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SargentRF.Data
{
    public class SargentRFDbContext : DbContext
    {
        public SargentRFDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
