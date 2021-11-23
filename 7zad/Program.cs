//Source: Trust me bro
using System;

namespace _7zad
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Console.WriteLine("Sex 1:");
            person1.Sex = char.Parse(Console.ReadLine());
            Console.WriteLine("Age 1:");
            person1.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Name 1:");
            person1.Name = Console.ReadLine();

            Person person2 = new Person();
            Console.WriteLine("Sex 2:");
            person2.Sex = char.Parse(Console.ReadLine());
            Console.WriteLine("Age 2:");
            person2.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Name 2:");
            person2.Name = Console.ReadLine();

            Console.WriteLine(person1.Age > person2.Age ?
                $"{person1.Name}, {person1.Age}, {person1.Sex}" :
                $"{person2.Name}, {person2.Age}, {person2.Sex}");


        }
    }
}
