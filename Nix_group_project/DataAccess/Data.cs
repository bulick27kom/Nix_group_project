using Core;
using Core.Entites;

namespace DataAccess;
public class Data
{
    private static Data? _data;
    public static Data Instance()
    {
        if (_data is null)
        {
            _data = new();
        }
        return _data;
    }
    private Data()
    {
        Products = GenerateProducts(50);
        Categories = GenerateCategories(10);
        BindingProductsWithCategory(Products, Categories);
        Manufacturers = GenerateManufacturer(5);
        BindingProductsWithManufacturers(Products, Manufacturers);
    }
    public List<Person> People { get; set; } = new()
    {

        new Person()
        {
            Id = 1,
            FirstName ="Max",
            LastName ="Peterson",
            BirthDate = DateTime.Now,
        },
         new Person()
        {
            Id = 2,
            FirstName ="Goofy",
            LastName ="Bark",
            BirthDate = DateTime.Now.AddDays(-1),
        }
    };
    public List<Article> Articles { get; set; } = new()
    {

        new Article()
        {
            Id = 1,
            Title ="Max",
            Text ="Peterson",
        },
         new Article()
        {
            Id = 2,
            Text ="Goofy",
            Title ="Bark",
        }
    };

    public List<Product> Products { get; set; }

    public List<Category> Categories { get; set; } 

    public List<Manufacturer> Manufacturers { get; set; }

    private List<Product> GenerateProducts(int count)
    {
        List<Product> products = new List<Product>();
        for (int i = 1; i <= count; i++)
        {
            products.Add(new Product() 
            {
                Id = i,
                Name = $"Product {i}",
                Description = $"Discriprion of product {i}",
                Price = i * 100,
               
            });
        }

        return products;
    }

    private List<Category> GenerateCategories(int count)
    { 
        List<Category> categories = new List<Category>();
        for (int i = 1; i <= count; i++)
        {
            categories.Add(new Category()
            {
                CategoryId = i,
                CategoryName = $"Category N {i}"
            });
        }
        return categories;
    }

    private void BindingProductsWithCategory(List<Product> products, List<Category> categories)
    {
        foreach (var product in products)
        {
            Random rand = new Random();
            product.CategoryID = rand.Next(1, categories.Count);   
        }
    }

    private List<Manufacturer> GenerateManufacturer(int count)
    {
        var manufacturers = new List<Manufacturer>();
        for (int i = 1; i < count; i++)
        {
            manufacturers.Add(new Manufacturer()
            {
                Id = i,
                Name = $"Manufacturer N {i}"
            });
        }
        return manufacturers;
    }

    private void BindingProductsWithManufacturers(List<Product> products, List<Manufacturer> manufacturers)
    {
        foreach (var product in products)
        {
            Random rand = new Random();
            int manufacturerId = rand.Next(1, manufacturers.Count);
            product.ManufacturerId = manufacturerId;
            manufacturers[manufacturerId].Products.Add(product);
        }
    }

}
