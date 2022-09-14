namespace Core
{
    public class Category {
        public int Id { get; set; }
        public string Name { set; get; }
        public string Description { set; get; }

        public List<Product> Products;
    }

    public class Rating
    {
        public Product Product { get; set; }
        public uint RatingSize { get; set; } 
    }

}
