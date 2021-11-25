using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Visit
{
    class Visit
    {
        string date;
        string time;
        int dayOfTheWeek;
        int quantity;
        double stay;
        string nameOfWeb;

        public string Date { get; set; }
        public string Time { get; set; }
        public int DayOfTheWeek { get { return dayOfTheWeek; } set { if (value > 0 && value < 8) dayOfTheWeek = value; } }
        public int Quantity { get; set; }

    }
}
