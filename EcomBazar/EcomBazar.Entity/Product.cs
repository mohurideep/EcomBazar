using System;
using System.Collections.Generic;
using System.Text;

namespace EcomBazar.Entity
{
    public class Product: BaseEntity
    {
        public decimal Price { get; set; }
        public Category Category { get; set; }
    }
}
