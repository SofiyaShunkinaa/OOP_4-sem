using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


    public class FlowerContext : DbContext
    {
        public FlowerContext() : base("DefaultConnection")
        {

        }
        public DbSet<Flower> Flowers { get; set; }
    }

