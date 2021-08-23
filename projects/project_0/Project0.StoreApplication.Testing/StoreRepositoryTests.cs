using System.Reflection;
using Xunit;
using Project0.StoreApplication.Storage.Repositories;
using Project0.StoreApplication.Domain;

namespace Project0.StoreApplication.Testing
{
 
    public class StorageRepositoryTests
    {
        [Fact]
        public void Test_StoreCollection()
        {
            var sut = new StoreRepository();

            var actual = sut.Stores;

            Assert.NotNull(actual);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]

        public void Test_OneStore(int arg)
        {
            var sut = new StoreRepository();

            var store = sut.GetStore(arg);

            Assert.NotNull(store);
        }
    }
}

