using System;
using Core.Entites;
using Core.Interfaces;

namespace DataAccess.Repositories
{
    public class CategoryRepository
    {
        public CategoryRepository : ICategoryRepositiry
        {
            private readonly ProductEntities db = new ProductEntities();

        public void Add(Category c)
        {
            throw new NotImplementedException();
        }

        public void Edit(Category c)
        {
            throw new NotImplementedException();
        }

        public Category FindById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetCategories()
        {
            return db.Categories;
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
    }
}

