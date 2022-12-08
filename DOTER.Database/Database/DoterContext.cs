using DOTER.Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTER.Database.Database
{
   public class DoterContext :DbContext
    {
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Breeder> Breeders{ get; set; }
        public DbSet<Consumer> Consumers{ get; set; }
        public DbSet<Purchase> purchases { get; set; }
        public DbSet<PurchaseDetail>purchaseDetails { get; set; }

        public DoterContext(DbContextOptions<DoterContext> options) : base(options) { }
    }
}

