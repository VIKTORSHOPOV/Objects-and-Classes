using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Bread
{
    class Bread
    {

        double weight;
        double percent;
        double price;
        int breadCount;

        public string BreadName { get; set; }
        public double Weight { get { return weight; } set { if (value > 0) weight = value; } }
        public string FlourType { get; set; }
        public double Percent { get { return percent; } set { if (value > 0 && value <= 100) percent = value; } }
        public double Price { get { return price; } set { if (value > 0) price = value; } }
        public int BreadCount { get { return breadCount; } set { if (value >= 0) breadCount = value; } }

        public Bread()
        {
            BreadName = "";
            weight = 1;
            FlourType = "";
            percent = 0;
            price = 0;
            breadCount = 0;
        }

        public Bread(string breadName, double weight, string flourType, double percent, int breadCount)
        {
            BreadName = breadName;
            this.weight = weight;
            FlourType = flourType;
            this.percent = percent;
            this.breadCount = breadCount;

            double priceOfFlour = 0;

            switch (FlourType)
            {
                case "White": priceOfFlour = .8; break;
                case "Brown": priceOfFlour = .5; break;
                case "Grain": priceOfFlour = .95; break;
                default: break;
            }
            double price = priceOfFlour * weight + percent * .03 + .18;
            this.price = price;
        }

        public Bread(string breadName, string flourType) : this()
        {
            this.BreadName = breadName;
            this.FlourType = flourType;

            double priceOfFlour = 0;

            switch (FlourType)
            {
                case "White": priceOfFlour = .8; break;
                case "Brown": priceOfFlour = .5; break;
                case "Grain": priceOfFlour = .95; break;
                default: break;
            }
            double price = priceOfFlour * weight + percent * .03 + .18;
            this.price = price;
        }

        public void ProductInfo()
        {
            Console.WriteLine($"{BreadName}, {weight:F3}, {FlourType} , supplements {percent * 100}%, {price} lv");
        }

        public double ValueOfProducts()
        {
            return price * BreadCount;
        }

        public int ComparePrice(Bread b)
        {
            if (weight == b.weight)
        }







    }
}
