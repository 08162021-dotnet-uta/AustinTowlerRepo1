using System.Collections.Generic;

namespace Project0.StoreApplication.Storage.Interfaces
{
    public interface IRepository<T> where T : class 
    {
        bool Delete();

        bool Insert(T entry);

        List<T> Select();

        T Update();
    }
}