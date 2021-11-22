using System;

namespace _11zad
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Rectangle rec = new Rectangle(a, b);
            Console.WriteLine($"Rectangle Area {rec.area_rec():f2}");
            double c = double.Parse(Console.ReadLine());
            Circle cir = new Circle(c);
            Console.WriteLine($"Circle Area {cir.Area_circle():f2}");
        }
    }
}
