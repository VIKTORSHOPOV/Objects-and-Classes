using System;

namespace _9zad
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Brand = "Toyota";
            car.Model = "Yaris";
            car.Year = 1999;
            car.FuelQuantity = 200;
            car.FuelConsumption = 5;
            Console.WriteLine(car.WhoAmI());
            car.Drive(200);
            Console.WriteLine(car.WhoAmI());

        }
    }
}
