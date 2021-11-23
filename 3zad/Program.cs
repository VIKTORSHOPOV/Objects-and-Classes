//Source: Trust me bro
using System;

namespace _3zad
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.name = Console.ReadLine();
            student.clas = Console.ReadLine();
            student.ID = Console.ReadLine();
            student.dBel = double.Parse(Console.ReadLine());
            student.dForeign = double.Parse(Console.ReadLine());
            student.dMath = double.Parse(Console.ReadLine());
            student.dPhys = double.Parse(Console.ReadLine());
            student.dChem = double.Parse(Console.ReadLine());
            student.dBio = double.Parse(Console.ReadLine());
            student.average = (student.dBel + student.dMath + student.dPhys + student.dChem + student.dBio + student.dForeign) / 6;
            Console.WriteLine("Name " + student.name);
            Console.WriteLine("Class " + student.clas);
            Console.WriteLine("ID " + student.ID);
            Console.WriteLine("BEL " + student.dBel);
            Console.WriteLine("Ezik " + student.dForeign);
            Console.WriteLine("Matematika " + student.dMath);
            Console.WriteLine("Fizika " + student.dPhys);
            Console.WriteLine("Himiq " + student.dChem);
            Console.WriteLine("Biologiq " + student.dBio);
            Console.WriteLine($"{student.average:F2}");
        }
    }
}
