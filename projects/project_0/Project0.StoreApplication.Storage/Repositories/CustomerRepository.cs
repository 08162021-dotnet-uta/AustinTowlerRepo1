using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;
using Project0.StoreApplication.Storage.Interfaces;

namespace Project0.StoreApplication.Storage.Repositories
{

    public class CustomerRepository : IRepository<Customer>
    {

        private const string _path = @"C:\Users\Owner\Desktop\AustinTowlerRepo1\projects\project_0\Data\customers.xml";
        private static readonly FileAdapter _fileAdapter = new FileAdapter();

        public CustomerRepository()
        {
            if (_fileAdapter.ReadFromFile<Customer>(_path) == null)
            {
                _fileAdapter.WriteToFile<Customer>(_path, new List<Customer>());
            }
        }
        public bool Delete()
        {
            throw new System.NotImplementedException();
        }

        public bool Insert(Customer entry)
        {
            _fileAdapter.WriteToFile<Customer>(_path, new List<Customer> { entry });

            return true;
        }

        public List<Customer> Select()
        {
            return _fileAdapter.ReadFromFile<Customer>(_path);
        }

        public Customer Update()
        {
            throw new System.NotImplementedException();
        }
    }
}