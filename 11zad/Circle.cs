using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11zad
{
    class Circle
    {
        private double R;
        public Circle()
        {
            R = 0;
        }
        public Circle(double r)
        {
            R = r;
        }
        public double Area_circle()
        {
            return Math.PI * R * R;
        }
    }
}
