using System;

namespace _1zad
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Brand = "Toyota";
            myCar.Model = "Supra";
            myCar.EngineVolume = 3000;
            myCar.YearProduced = 2020;
            Console.Write($"{myCar.Brand}, {myCar.Model}, {myCar.EngineVolume}, {myCar.YearProduced}");
        }
    }
}
