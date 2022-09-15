using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core
{
    public class ProductCategory
    {
        public int Id{get;set;}

        public string Name{get;set;}

        public List<Product> Products { get; set; }
    }
}