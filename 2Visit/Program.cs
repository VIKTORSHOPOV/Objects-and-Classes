using System;

namespace _2Visit
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            string time = Console.ReadLine(); ;
            int dayOfTheWeek = int.Parse(Console.ReadLine());
            int quantity = int.Parse(Console.ReadLine());
            int stay = int.Parse(Console.ReadLine());
            string nameOfWeb = Console.ReadLine();
            Visit v1 = new Visit(date, time, dayOfTheWeek, quantity, stay, nameOfWeb);
            v1.InfoForVisit();

            date = Console.ReadLine();
            time = Console.ReadLine(); ;
            dayOfTheWeek = int.Parse(Console.ReadLine());
            quantity = int.Parse(Console.ReadLine());
            stay = int.Parse(Console.ReadLine());
            Visit v2 = new Visit(date, time, dayOfTheWeek, quantity, stay);
            v2.InfoForVisit();

            Console.WriteLine(v1.CalcAllData(v2));
        }
    }
}
