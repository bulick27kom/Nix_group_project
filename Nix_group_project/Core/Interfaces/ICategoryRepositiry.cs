using System;
using Core.Entites;

namespace Core.Interfaces
{
    public interface ICategoryRepositiry
    {
        void Add(Category c);
        void Edit(Category c);
        void Remove(int id);
        IEnumerable<Category> GetCategories();
        Category FindById(int id);
    }
}

