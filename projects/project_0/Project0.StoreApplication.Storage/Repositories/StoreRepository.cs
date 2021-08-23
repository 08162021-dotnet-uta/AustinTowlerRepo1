using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.FileAdapters;

namespace Project0.StoreApplication.Storage.Repositories
{
    public class StoreRepository
    {
        private const string _path = @"/home/altowler/revature/austin_code/data/project_0.xml";
        private static StoreRepository _storeRepository;
        public List<Store> Stores { get; set;}

        private StoreRepository()
        {
            var fileAdapter = new FileAdapter();
            // Stores = new List<Store>()
            //     {
            //     new Store("Alpha"),
            //     new Store("Beta"),
            //     new Store("Gamma")
            // };

            Stores = fileAdapter.ReadFromFile<Store>(_path);
        
        }

        public Store GetStore(int index)
        {
            try 
            {
                return Stores[index];
            }
            catch 
            {
                return null;
            }
        
        }

        public static StoreRepository Instance
        {
            get
            {
                if (_storeRepository == null)
                    {
                        _storeRepository = new StoreRepository();
                    }

                return _storeRepository;
            }
        }

    }

        
}

