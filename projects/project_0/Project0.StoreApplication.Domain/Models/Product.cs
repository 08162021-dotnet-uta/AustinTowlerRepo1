using System;
using System.ComponentModel.DataAnnotations;

namespace Project0.StoreApplication.Domain.Models
{
    public class Product
    {

        public String Name {get; set;}
        public decimal Price { get; set; }
        
        public Product()
        {
            Name = "Foo";
            Price = 24.99m;
        }

        public override string ToString()
        {
          return $"{Name}\t{Price}";
        }
    }
}