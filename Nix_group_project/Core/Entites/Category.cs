using System;
namespace Core.Entites
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        //public string Description

    }
}

