using System;
using Test.DataAccess;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coffee App");

            Console.WriteLine("write Help command to work ");

            var coffeeShopDataProvider = new CoffeeDataProvider();

            while (true)
            {
                var line = Console.ReadLine();

                var coffeeShopes = coffeeShopDataProvider.LoadcoffeeShops();

                if (string.Equals("help", line, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Available Coffee Shopes Commend");
                    foreach(var cofee in coffeeShopes)
                    {
                        Console.WriteLine($">" + cofee.Location);
                    }
                }
            }
        }
    }
}
