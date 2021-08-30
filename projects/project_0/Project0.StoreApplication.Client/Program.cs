using System;
using System.Collections.Generic;
using Project0.StoreApplication.Client.Singletons;
using Project0.StoreApplication.Domain.Models;

namespace Project0.StoreApplication.Client
{
    class Program
    {

        private static readonly CustomerSingleton _customerSingleton = CustomerSingleton.Instance;
        private static readonly StoreSingleton _storeSingleton = StoreSingleton.Instance;
        private static readonly OrderSingleton _orderSingleton = OrderSingleton.Instance;
        private static readonly ProductSingleton _productSingleton = ProductSingleton.Instance;

        private static Customer currentCustomer;
        private static Store currentStore;
        private const string _logPath = @"/home/altowler/revature/austin_code/data/project_0.xml";
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AUSTIN-MART!");
            Run();

        }

        private static void Run()
        {
            Console.WriteLine("Are you a Customer or Store?");
            Console.WriteLine("[1] - Customer \n[2] - Store");
            int choice  = int.Parse(Console.ReadLine());

            if(choice == 1) { RunCustomer(); }
            if(choice == 2) { RunStore(); }

        }

        private static void RunCustomer()
        {
            currentCustomer = _customerSingleton.Customers[Capture<Customer>(_customerSingleton.Customers)];

            Console.WriteLine(currentCustomer);
        }

        private static void RunStore()
        {
            currentStore = _storeSingleton.Stores[Capture<Store>(_storeSingleton.Stores)];
            
            ViewStoreOptions(currentStore);
        }

        private static void ViewStoreOptions(Store store)
        {
            foreach (Order x in _orderSingleton.Orders)
            {
                if(x.Store == store.Name)
                {
                    Console.WriteLine(x.OrderTotal);
                }
            }
        }

        // private static void Run()
        // {
        //     if(_customerSingleton.Customers.Count == 0)
        //     {
        //         _customerSingleton.Add(new Customer());
        //     }

        //     if(_storeSingleton.Stores.Count == 0)
        //     {
        //         _storeSingleton.Add(new Store());
        //     }

        //     if(_orderSingleton.Orders.Count == 0)
        //     {
        //         _orderSingleton.Add(new Order());
        //     }

        //     if(_productSingleton.Products.Count == 0)
        //     {
        //         _productSingleton.Add(new Product());
        //     }

        //     var customer = _customerSingleton.Customers[Capture<Customer>(_customerSingleton.Customers)];
        //     var store = _storeSingleton.Stores[Capture<Store>(_storeSingleton.Stores)];
        //     var order = _orderSingleton.Orders[Capture<Order>(_orderSingleton.Orders)];
        //     var products = _productSingleton.Products[Capture<Product>(_productSingleton.Products)];

        //     Console.WriteLine(products);
        // }

        private static void Output<T>(List<T> data) where T: class
        {
            var index = 0;

            foreach(var item in data)
            {
                Console.WriteLine($"[{++index}] - {item}");
            }
        }

        private static int Capture<T>(List<T> data) where T : class
        {
            Output<T>(data);
            Console.Write("Make selection: ");

            int selected = int.Parse(Console.ReadLine());

            return selected - 1;
        }

        
    }
}
