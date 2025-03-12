using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main()
        {
            Product apple = new Product("Apple", 5, 100);
            Console.WriteLine(apple.GetInfo());

            apple.Sell(20);
            Console.WriteLine(apple.GetInfo());

            apple.Restock(50);
            Console.WriteLine(apple.GetInfo());

            apple.Price = 7;
            Console.WriteLine(apple.GetInfo());

            apple.Name = "Green Apple";
            Console.WriteLine(apple.GetInfo());

            try
            {
                apple.Price = -10;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                apple.Name = "";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            apple.Sell(200);
        }
    }
}