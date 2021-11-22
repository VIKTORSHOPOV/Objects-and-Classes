using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11zad
{
    class Rectangle
    {
        {
        private double width;
        private double height;
        public Rectangle()
        {
            width = 0;
            height = 0;
        }
        public Rectangle(double w, double h)
        {
            width = w;
            height = h;
        }
        public double area_rec()
        {
            return width * height;
        }
    }
}
