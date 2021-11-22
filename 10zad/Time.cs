using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10zad
{
    class Time
    {
        int hours;
        int minutes;
        int seconds;

        public Time()
        {
            hours = 0;
            minutes = 0;
            seconds = 0;
        }
        public Time(int h, int m, int s)
        {
            hours = h;
            minutes = m;
            seconds = s;
        }

        public void GetHour()
        {
            Console.WriteLine($"{hours:D2}:{minutes:D2}:{seconds:D2}");
        }

    }
}
