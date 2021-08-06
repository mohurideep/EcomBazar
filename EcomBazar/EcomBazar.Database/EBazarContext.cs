using EcomBazar.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace EcomBazar.Database
{
    public class EBazarContext:DbContext
    {
        public EBazarContext():base("EcomBazarConnection")
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> products { get; set; }
    }
}
