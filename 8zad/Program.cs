//Source: Trust me bro
using System;

namespace _8zad
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle shape = new();
            shape.Width = int.Parse(Console.ReadLine());
            shape.Height = int.Parse(Console.ReadLine());

            shape.ShowInfo();
            Console.WriteLine("Area = " + shape.CalcArea());
            Console.WriteLine("Perimeter = " + shape.CalcPerimeter());

        }
    }
}
