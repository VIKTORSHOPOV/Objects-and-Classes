//Source: Trust me bro
using System;

namespace _2zad
{
    class Program
    {
        static void Main(string[] args)
        {
            Car1 myCar = new Car1();
            Console.WriteLine("Car Brand");
            myCar.brand = Console.ReadLine();
            Console.WriteLine("Car Model");
            myCar.model = Console.ReadLine();
            Console.WriteLine("Engine Volume");
            myCar.engineVolume = int.Parse(Console.ReadLine());
            Console.WriteLine("Year Produced");
            myCar.yearProduced = int.Parse(Console.ReadLine());
            double fees = 0.2 * myCar.engineVolume;
            if (myCar.yearProduced <= 2000)
            {
                fees += 70;

            }
            if (myCar.yearProduced > 2000 && myCar.yearProduced <= 2010)
            {
                fees += 60;
            }
            else
            {
                fees += 50;
            }
            Console.WriteLine($"Fee for {myCar.brand}, {myCar.model}, {myCar.yearProduced} = {fees}");
        }
    }
}
