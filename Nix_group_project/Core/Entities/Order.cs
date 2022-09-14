namespace Core
{
    class Order
    {
        public Person Person { get; set; }
        public List<Product> Products { get; set; }
        public DateTime DateOrder { get; set; }
    }

}
