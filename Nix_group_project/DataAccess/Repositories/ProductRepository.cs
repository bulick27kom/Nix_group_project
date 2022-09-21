using System;
using Core;
using Core.Interfaces;

namespace DataAccess.Repositories
{
    public class ProductRepository : IProductRepository
    { 
            private readonly ProductsEntities db = new ProductsEntities();

            public void Add(Product pr)
            {
                db.Products.Add(pr);
                db.SaveChanges();
            }

            public void Edit(Product pr)
            {
                db.Entry(pr).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

            public Product FindById(int id)
            {
                var result = (from pr in db.Products
                              join c in db.Categories on pr.CategoryID equals c.CategoryID
                              where pr.ProductID == id
                              select pr.FirstOrDefault();

                return result;
            }

            public IEnumerable<Product> GetProducts()
            {
                return db.Products.Include(c => c.Category);
            }

            public void Remove(int id)
            {
                Product pr = db.Products.Find(id);
                db.Products.Remove(pr);
                db.SaveChanges();
            }
        }
    }
}

