namespace Core
{
    public class Person 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Order> Orders;

        public UserAutorizedStatus autorizedStatus = UserAutorizedStatus.Guest;   
    }

    


}
