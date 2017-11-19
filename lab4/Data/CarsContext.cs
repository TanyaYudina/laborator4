using lab4.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab4.Data
{
    public class CarsContext : DbContext
    {
        public CarsContext(DbContextOptions<CarsContext> options) : base(options)
        {
        }
        public DbSet<AdditionalServices> AdditionalServices { get; set; }
        public DbSet<CarsRental> CarsRental { get; set; }
        public DbSet<Customers> Customers { get; set; }
    }
}
