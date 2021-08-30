using System.Collections.Generic;
using System.Data;
using System.IO;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;
using Project0.StoreApplication.Storage.Interfaces;

namespace Project0.StoreApplication.Storage.Repositories
{
    public class StoreRepository : IRepository<Store>
    {
        private const string _path = @"C:\Users\Owner\Desktop\AustinTowlerRepo1\projects\project_0\Data\stores.xml";
        private static readonly FileAdapter _fileAdapter = new FileAdapter();

        public StoreRepository()
        {
            if (_fileAdapter.ReadFromFile<Store>(_path) == null)
            {
                _fileAdapter.WriteToFile<Store>(_path, new List<Store>());
            }
        }

        public bool Delete()
        {
            throw new System.NotImplementedException();
        }

        public bool Insert(Store entry)
        {
            _fileAdapter.WriteToFile<Store>(_path, new List<Store> { entry });

            return true;
        }

        public List<Store> Select()
        {
            return _fileAdapter.ReadFromFile<Store>(_path);
        }

        public Store Update()
        {
            throw new System.NotImplementedException();
        }
    }


}

