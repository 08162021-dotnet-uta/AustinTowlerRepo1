using System;

namespace Project0.StoreApplication.Domain.Models
{
    public class Store
    {
        public string Name { get; set;}

        public Store(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return  Name ?? DateTime.Now.ToLongDateString();
            
        }
    }
}