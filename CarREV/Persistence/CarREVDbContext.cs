using CarREV.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarREV.Persistence
{
    public class CarREVDbContext : DbContext
    {
        public CarREVDbContext(DbContextOptions<CarREVDbContext> options) : base(options)
        {
             
        }
        public DbSet<Make> Makes { get; set; }
        public DbSet<Feature> Features { get; set; }
    }
}
