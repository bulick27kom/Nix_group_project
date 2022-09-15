using System.Reflection.Metadata.Ecma335;

namespace Core;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<ProductCategory> Categories { get; set; }
    public Manufacturer Manufacturer { get; set; }
    public List<Comment>? Comments { get; set; }
    public int Rating { get; set; }

}
