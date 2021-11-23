//Source: Trust me bro
using System;


namespace _12zad
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student();
            st1.Print();
            string name = Console.ReadLine();
            int nomer = int.Parse(Console.ReadLine());
            string spec = Console.ReadLine();
            int kurs = int.Parse(Console.ReadLine());
            Student st2 = new Student(name, nomer, spec, kurs);
            st2.Print();
            Student st3 = new Student(st2);
            st3.Print();
        }
    }
}
