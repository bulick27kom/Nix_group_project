namespace Core
{
    public class Category {
        public int Id { get; set; }
        public string Name { set; get; }
        public string Description { set; get; }

        public List<Product> Products;
    }

}
