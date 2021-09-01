using System.Reflection;
using Xunit;
using Project0.StoreApplication.Client.Singletons;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;
using System.Runtime.Remoting;
using System.ComponentModel;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Project0.StoreApplication.Testing
{
    public class StoreApplicationTest
    {

        #region Domain
        
        [Fact]
        public void TestCustomerToString()
        {
            Customer cust = new Customer();
            cust.Name = "Test";
            Assert.Equal("Test", cust.ToString());
        }

        [Fact]
        public void TestProductToString()
        {
            Product prod = new Product();
            prod.Name = "Test";
            prod.Price = 10.00m;
            Assert.Equal($"Test\t{prod.Price}", prod.ToString());
        }

        [Fact]
        public void TestOrderToString()
        {
            Order ord = new Order();
            List<Product> prodList = new List<Product>();
            Product prod = new Product();
            prod.Name = "Foo";
            prod.Price = 10.00m;
            prodList.Add(prod);
            ord.Customer = "Test";
            ord.Store = "Test Store";
            ord.Products = prodList;

            Assert.Equal($"Customer:{ord.Customer}\n\t Location: {ord.Store}\n\t Items: {ord.Products} For a total of: {ord.Products.Count} items\n\t Total: {prod.Price}", ord.ToString());
        }

        [Fact]
        public void TestStoreToString()
        {
            Store store = new Store();
            store.Name = "Test";
            Assert.Equal("Test", store.ToString());
        }

        #region SR

        [Fact]
        public void Test_StoreCollection()
        {
            var sington = StoreSingleton.Instance;
            var actual = sington.Stores;

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_CustomerCollection()
        {
            var sington = CustomerSingleton.Instance;
            var actual = sington.Customers;

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_OrderCollection()
        {
            var sington = OrderSingleton.Instance;
            var actual = sington.Orders;

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_ProductCollection()
        {
            var sington = ProductSingleton.Instance;
            var actual = sington.Products;

            Assert.NotNull(actual);
        }
        #endregion SR

        #endregion Domain

        #region FileAdapter

        [Fact]
        public void TestFileAdapter()
        {
            var fa = new FileAdapter();

            var actual = fa.ReadFromFile<object>("path");
            Assert.IsType<List<object>>(actual);
            Assert.NotEmpty(actual);
        }
        #endregion FileAdapter
    }
}