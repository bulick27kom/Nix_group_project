using System;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        void Add(Product pr);
        void Edit(Product pr);
        void Remove(int id);
        IEnumerable<Product> GetProducts();
        Product FindById(int id);
    }
}


