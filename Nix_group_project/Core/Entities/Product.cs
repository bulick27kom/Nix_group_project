namespace Core
{
    public class Product
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; private set; }


        public List<Category> Categories;
        public List<Comment> Comments;
    }

    


}
