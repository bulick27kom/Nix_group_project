using System;
using Core.Interfaces;

namespace Core.Controllers
{
    public class ProductController
    {
            private IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }
    }
    
}

