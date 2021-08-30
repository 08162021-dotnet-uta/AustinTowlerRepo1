using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project0.StoreApplication.Domain.Models
{
    public class Customer
    {
        public string Name { get; set; }

        public Customer()
        {
          Name = "Test Testerson";
        }

        public override string ToString()
        {
          return $"{Name}";
        }
  }
}