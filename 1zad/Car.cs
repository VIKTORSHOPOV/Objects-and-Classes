using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1zad
{
    class Car
    {
        private string brand;
        private string model;
        private int engineVolume;
        private int yearProduced;
        public string Brand
        {
            set { this.brand = value; }
            get { return this.brand; }
        }
        public string Model
        {
            set { this.model = value; }
            get { return this.model; }
        }
        public int EngineVolume
        {
            set { this.engineVolume = value; }
            get { return this.engineVolume; }
        }
        public int YearProduced
        {
            set { this.yearProduced = value; }
            get { return this.yearProduced; }
        }

    }
}
