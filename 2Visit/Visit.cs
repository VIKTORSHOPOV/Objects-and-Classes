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
        public int Quantity { get { return quantity; } set { if (value! < 0) quantity = value; } }
        public double Stay { get { return stay; } set { if (value! < 0) stay = value; } }
        public string NameOfWeb { get; set; }

        public Visit()
        {
            date = "";
            time = "";
            dayOfTheWeek = 0;
            quantity = 0;
            stay = 0;
            nameOfWeb = "";
        }

    }
}
