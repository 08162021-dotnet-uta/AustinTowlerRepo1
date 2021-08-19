using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Repositories;

namespace Project0.StoreApplication.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintAllStoreLocations();
            Console.WriteLine(SelectStore());
        }

        static void PrintAllStoreLocations()
        {
            var storeLocations = new StoreRepository();

             foreach(Store store in storeLocations.Stores)
             {
                 Console.WriteLine("[" + (storeLocations.Stores.IndexOf(store) + 1) +"]" + store.Name);
             }
        }

        static Store SelectStore()
        {
            var stores = (new StoreRepository().Stores);
            Console.WriteLine("Select a store: ");
            return  (stores[int.Parse(Console.ReadLine()) - 1]);
        }
    }
}
