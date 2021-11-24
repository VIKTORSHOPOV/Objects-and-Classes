using System;

namespace _14zad
{
    class Program
    {
        static void Main(string[] args)
        {
            string brand = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            int fuelQuantity = int.Parse(Console.ReadLine());
            int fueConsumation = int.Parse(Console.ReadLine());
            Car firstCar = new Car();
            Car secondCar = new Car(brand, model, year);
            Car thirdCar = new Car(brand, model, year, fuelQuantity, fueConsumation);
            Console.WriteLine(firstCar.WhoAmI());
            Console.WriteLine(secondCar.WhoAmI());
            Console.WriteLine(thirdCar.WhoAmI());
        }
    }
}
