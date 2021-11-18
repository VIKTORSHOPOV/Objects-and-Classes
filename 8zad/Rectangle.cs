using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8zad
{
    class Rectangle
    {
        //private double width;
        //private double height;
        

        public double Width
        {
            get;set;
        }
        public double Height
        {
            get; set;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"width: {Width}");
            Console.WriteLine($"height: {Height}");
        }

        public double CalcArea()
        {
            return Width * Height;
        }
        public double CalcPerimeter()
        {
            return (Width + Height) * 2;
        }



    }
}
