using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14zad
{
    class Car
    {
        private string brand;
        private string model;
        private int year;
        private int FuelQuantity;
        private int FuelConsumption;
        public Car()
        {
            this.brand = "VW";
            this.model = "Golf";
            this.year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;

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
