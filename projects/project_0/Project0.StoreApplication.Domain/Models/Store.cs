using System;
using System.Collections.Generic;
using System.Xml;

namespace Project0.StoreApplication.Domain.Models
{
    public class Store
    {
        public string Name { get; set;}

        public Store()
        {
            Name = "Test Store";
        }

        public override string ToString()
        {
            return  Name ?? DateTime.Now.ToLongDateString();
        }
    }
}