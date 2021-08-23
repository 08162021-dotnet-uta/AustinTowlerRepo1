using System;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Repositories;

namespace Project0.StoreApplication.Client
{
    class Program
    {

        static void Main(string[] args)
        {
            PrintAllStoreLocations();
            PrintOutput();
        }

        static void PrintAllStoreLocations()
        {
            var storeLocations = StoreRepository.Instance;

             foreach(Store store in storeLocations.Stores)
             {
                Console.WriteLine("[" + (storeLocations.Stores.IndexOf(store) + 1) +"]" + store.Name);
             }
        }

        private static Store SelectStore()
        {
            var stores = (StoreRepository.Instance.Stores);
            Console.WriteLine("Select a store: ");
            return  (stores[int.Parse(Console.ReadLine()) - 1]);
        }

        private static void PrintOutput()
        {
            Console.WriteLine(SelectStore());        
        }
    }
}
