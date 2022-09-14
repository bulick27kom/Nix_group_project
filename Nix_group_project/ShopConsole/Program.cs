using Core;

internal class Program
{
    private static void Main(string[] args)
    {
        ShopProcessor shopProcessor = new ShopProcessor();
        shopProcessor.SayHello();
    }

    internal class ShopProcessor
    {
        Person user = null;
        internal void Start()
        {
            SayHello();
        }

        internal void SayHello()
        {
            string userName = "";
            if (user == null) userName = "Guest";
            else userName = user.ToString();
            Console.WriteLine($"Hello {userName}");
        }

        internal void ShowMainMenu()
        {
            
        }

    }
}