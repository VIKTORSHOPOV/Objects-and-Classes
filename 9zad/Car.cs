using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9zad
{
    class Car
    {
        private string brand;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        public string Brand { get { return brand; } set { brand = value; } }
        public string Model { get { return model; } set { model = value; } }
        public int Year { set { if (value >= 1886 && value <= 2021) year = value; else Console.WriteLine("Nekorektni danni"); } get { return year; } }
        public double FuelQuantity
        {
            set { if (value >= 0) fuelQuantity = value; else Console.WriteLine("Nekorektni danni"); }
            get { return fuelQuantity; }
        }

        public double FuelConsumption
        {
            set { if (value > 0) fuelConsumption = value; else Console.WriteLine("Nekorektni danni"); }
            get { return fuelConsumption; }

        }
        public void Drive(double distance)
        {
            if (fuelQuantity - distance * fuelConsumption >= 0)
            {
                fuelQuantity -= distance * fuelConsumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
        public string WhoAmI()
        {
            return $"Make: {Brand}\nModel: {Model}\nYear: {Year}\nFuel: {FuelQuantity:F2}";
        }

    }
}
