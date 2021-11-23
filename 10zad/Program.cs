//Source: Trust me bro
using System;

namespace _10zad
{
    class Program
    {
        static void Main(string[] args)
        {
            Time time1 = new Time();
            time1.GetHour();
            int val1 = int.Parse(Console.ReadLine());
            int val2 = int.Parse(Console.ReadLine());
            int val3 = int.Parse(Console.ReadLine());
            Time time2 = new Time(val1, val2, val3);
            time2.GetHour();
        }
    }
}
