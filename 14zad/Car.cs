using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14zad
{
    class Car
    {
        string brand;
        string model;
        int year;
        int FuelQuantity;
        int FuelConsumption;
        public Car()
        {
            brand = "VW";
            model = "Golf";
            year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;

        }
        public Car(string brand, string model, int year) : this()
        {
            this.brand = brand;
            this.model = model;
            this.year = year;

        }
        public Car(string brand, string model, int year, int FuelQuantity, int FuelConsumption) : this(brand, model, year)
        {
            this.FuelQuantity = FuelQuantity;
            this.FuelConsumption = FuelConsumption;
        }
        public string WhoAmI()
        {
            return $"Make: {brand}\nModel: {model}\nYear: {year}\nFuel: {FuelQuantity:f2}L\nFuelConsumption {FuelConsumption:f2}";
        }
    }
}
