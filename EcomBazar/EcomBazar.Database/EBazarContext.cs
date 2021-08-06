using EcomBazar.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EcomBazar.Database
{
    public class EBazarContext:DbContext
    {
        public EBazarContext(DbContextOptions<EBazarContext> options) :base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
