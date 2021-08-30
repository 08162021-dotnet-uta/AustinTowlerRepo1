using System.Collections.Generic;

namespace Project0.StoreApplication.Domain.Models
{
    public class Order
    {
        public string Customer { get; set; }
        public string Store { get; set; }
        public List<Product> Products {get; set;}

        public decimal OrderTotal {get; set;}

        public Order()
        {
            Customer = "Test Testerson";
            Store = "Test Store";
            Products = new List<Product>();
            OrderTotal = 0.00m;
        }
        
        public override string ToString()
        {
          return $"{Customer}\n\t {Store}\n\t {Products}\n\t {OrderTotal}";
        }
    }
}