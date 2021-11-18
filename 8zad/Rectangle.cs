using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8zad
{
    class Rectangle
    {
        private double width;
        private double height;
        

        public double Width
        {
            set { this.width = value; }
            get { return this.width; }
        }
        public double Height
        {
            set { this.height = value; }
            get { return this.height; }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"width:{width}");
            Console.WriteLine($"height:{height}");
        }

        public double CalcArea()
        {
            return width * height;
        }
        public double CalcPerimeter()
        {
            return (width + height) * 2;
        }



    }
}
