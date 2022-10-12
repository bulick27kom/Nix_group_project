using Core;
using Core.Entites;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    internal class StatisticServise
    {
        private readonly Data _data;
        public StatisticServise()
        {
            _data = Data.Instance();
        }

        public List<Product> MostExpendiveProducts()
        {
            return _data.Products.OrderBy(p => p.Price).Take(10).ToList();
        }

        public decimal AveragePriseOfProdutctsOfManufacturer (Manufacturer manufacturer)
        {
            var rez = _data.Products.Where(p => p.Manufacturer == manufacturer).Select(p =>  p.Price).Average();
            return rez is null? 0: (decimal)rez;
            
            
        }

        public IEnumerable MostCheapestCategories()
        {
            var rez = _data.Products.OrderByDescending( p=> p.Price)
                                    .Take(10)
                                    .Join(_data.Manufacturers, 
                                               p => p.ManufacturerId,
                                               m => m.Id,
                                               (p,m) => new { Product = p, Manufacturer = m
                                               });
            return rez;
        }

    }
}
