using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6zad
{
    class Student
    {
        private string name;
        private string clas;
        private string id;
        private double dBel;
        private double dForeign;
        private double dMath;
        private double dPhys;
        private double dChem;
        private double dBio;
        private double average;
        public string Clas
        {
            set { this.clas = value; }
            get { return this.clas; }
        }
        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }
        public string Id
        {
            set { this.id = value; }
            get { return this.id; }
        }
        public double DBel
        {
            set { if (value >= 2.00 && value <= 6.00) this.dBel = value; else { Console.WriteLine("Invalid grade"); } }
            get { return this.dBel; }
        }
        public double DForeign
        {
            set { if (value >= 2.00 && value <= 6.00) this.dForeign = value; else { Console.WriteLine("Invalid grade"); } }
            get { return this.dForeign; }
        }
        public double DMath
        {
            set { if (value >= 2.00 && value <= 6.00) this.dMath = value; else { Console.WriteLine("Invalid grade"); } }
            get { return this.dMath; }
        }
        public double DPhys
        {
            set { if (value >= 2.00 && value <= 6.00) this.dPhys = value; else { Console.WriteLine("Invalid grade"); } }
            get { return this.dPhys; }
        }
        public double DChem
        {
            set { if (value >= 2.00 && value <= 6.00) this.dChem = value; else { Console.WriteLine("Invalid grade"); } }
            get { return this.dChem; }
        }
        public double DBio
        {
            set { if (value >= 2.00 && value <= 6.00) this.dBio = value; else { Console.WriteLine("Invalid grade"); } }
            get { return this.dBio; }
        }
        public double Average
        {
            set { if (value >= 2.00 && value <= 6.00) this.average = value; else { Console.WriteLine("Invalid grade"); } }
            get { return this.average; }
        }

    }
}
