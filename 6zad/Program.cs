using System;

namespace _6zad
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine("Name:");
            student.Name = Console.ReadLine();
            Console.WriteLine("Class:");
            student.Clas = Console.ReadLine();
            Console.WriteLine("ID:");
            student.Id = Console.ReadLine();
            Console.WriteLine("Bel:");
            student.DBel = double.Parse(Console.ReadLine());
            Console.WriteLine("Foreign:");
            student.DForeign = double.Parse(Console.ReadLine());
            Console.WriteLine("Math:");
            student.DMath = double.Parse(Console.ReadLine());
            Console.WriteLine("Physics:");
            student.DPhys = double.Parse(Console.ReadLine());
            Console.WriteLine("Chemistry:");
            student.DChem = double.Parse(Console.ReadLine());
            Console.WriteLine("Biology:");
            student.DBio = double.Parse(Console.ReadLine());
            student.Average = (student.DBel + student.DMath + student.DPhys + student.DChem + student.DBio + student.DForeign) / 6;
            Console.WriteLine("Name " + student.Name);
            Console.WriteLine("Class " + student.Clas);
            Console.WriteLine("ID " + student.Id);
            Console.WriteLine("BEL " + student.DBel);
            Console.WriteLine("Ezik " + student.DForeign);
            Console.WriteLine("Matematika " + student.DMath);
            Console.WriteLine("Fizika " + student.DPhys);
            Console.WriteLine("Himiq " + student.DChem);
            Console.WriteLine("Biologiq " + student.DBio);
            Console.WriteLine($"{student.Average:F2}");

        }
    }
}
