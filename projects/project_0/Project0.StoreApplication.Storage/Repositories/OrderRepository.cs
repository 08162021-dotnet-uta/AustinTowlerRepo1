using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;

namespace Project0.StoreApplication.Storage.Interfaces
{
    public class OrderRepository : IRepository<Order>
    {

        private const string _path = @"C:\Users\Owner\Desktop\AustinTowlerRepo1\projects\project_0\Data\orders.xml";
        private static readonly FileAdapter _fileAdapter = new FileAdapter();

        public OrderRepository()
        {
            if (_fileAdapter.ReadFromFile<Order>(_path) == null)
            {
                _fileAdapter.WriteToFile<Order>(_path, new List<Order>());
            }           
        }

        public bool Delete()
        {
            throw new System.NotImplementedException();
        }

        public bool Insert(Order entry)
        {
            _fileAdapter.WriteToFile<Order>(_path, new List<Order> { entry });

            return true;
        }

        public System.Collections.Generic.List<Order> Select()
        {
            return _fileAdapter.ReadFromFile<Order>(_path);
        }

        public Order Update()
        {
            throw new System.NotImplementedException();
        }
    }
}