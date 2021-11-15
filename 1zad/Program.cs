using System;

namespace _1zad
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.brand = "Toyota";
            myCar.model = "Supra";
            myCar.engineVolume = 3000;
            myCar.yearProduced = 2020;
            Console.Write($"{myCar.brand}, {myCar.model}, {myCar.engineVolume}, {myCar.yearProduced}");
        }
    }
}
