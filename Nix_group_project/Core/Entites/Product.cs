using Core.Entites;

namespace Core;

public class Product
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string? Description { get; set; }

    public string? Factory { get; set; }

    public int? CategoryID { get; set; }

    public decimal? Price { get; set; }

    public int? ManufacturerId { get; set; }
    public Manufacturer? Manufacturer { get; set; }
    //public string ImagePath { get; set;} = "noimage.png";
}