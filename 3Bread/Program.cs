using System;

namespace _3Bread
{
    class Program
    {
        static void Main(string[] args)
        {
            string breadName = Console.ReadLine();
            double weight = double.Parse(Console.ReadLine());
            string flourType = Console.ReadLine();
            double percent = double.Parse(Console.ReadLine());
            int breadCount = int.Parse(Console.ReadLine());
            Bread b1 = new Bread(breadName, weight, flourType, percent, breadCount);
            b1.ProductInfo();
            Console.WriteLine($"Value of manufactured products for the day: {b1.ValueOfProducts()}");

            breadName = Console.ReadLine();
            weight = double.Parse(Console.ReadLine());
            flourType = Console.ReadLine();
            percent = double.Parse(Console.ReadLine());
            breadCount = int.Parse(Console.ReadLine());
            Bread b2 = new Bread(breadName, weight, flourType, percent, breadCount);
            b2.ProductInfo();
            Console.WriteLine($"Value of manufactured products for the day: {b2.ValueOfProducts()}");

            if (b1.Weight == b2.Weight)
            {
                switch (b1.ComparePrice(b2))
                {
                    case 0: Console.WriteLine($"Product {b1.BreadName} is cheaper than product {b2.BreadName}."); break;
                    case 1: Console.WriteLine($"Product {b1.BreadName} is more expensive than product {b2.BreadName}."); break;
                    case -1: Console.WriteLine($"Product {b1.BreadName} is the same price as product {b2.BreadName}."); break;
                    default: break;
                }
            }
            else
            {
                Console.WriteLine("The prices of the products cannot be compared");
            }
        }
    }
}
