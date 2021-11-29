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
        int stay;
        string nameOfWeb;

        public string Date { get; set; }
        public string Time { get; set; }
        public int DayOfTheWeek { get { return dayOfTheWeek; } set { if (value > 0 && value < 8) dayOfTheWeek = value; } }
        public int Quantity { get { return quantity; } set { if (value! < 0) quantity = value; } }
        public int Stay { get { return stay; } set { if (value! < 0) stay = value; } }
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

        public Visit(string date, string time, int dayOfTheWeek, int quantity, int stay, string nameOfWeb)
        {
            this.date = date;
            this.time = time;
            this.dayOfTheWeek = dayOfTheWeek;
            this.quantity = quantity;
            this.stay = stay;
            this.nameOfWeb = nameOfWeb;
        }

        public Visit(string date, string time, int dayOfTheWeek, int quantity, int stay) : this()
        {
            this.date = date;
            this.time = time;
            this.dayOfTheWeek = dayOfTheWeek;
            this.quantity = quantity;
            this.stay = stay;
        }

        public string CalcTime()
        {
            int hours = this.stay / 3600;
            int minutes = this.stay / 60 % 60;
            int sec = this.stay % 60;
            return $"{hours:D2}:{minutes:D2}:{sec:D2}";
        }

        public void InfoForVisit()
        {
            string dayOfTheWeekS = "";
            switch (this.dayOfTheWeek)
            {
                case 1: dayOfTheWeekS = "Monday"; break;
                case 2: dayOfTheWeekS = "Tuesday"; break;
                case 3: dayOfTheWeekS = "Wednesday"; break;
                case 4: dayOfTheWeekS = "Thursday"; break;
                case 5: dayOfTheWeekS = "Friday"; break;
                case 6: dayOfTheWeekS = "Saturday"; break;
                case 7: dayOfTheWeekS = "Sunday"; break;

                default:
                    break;
            }
            Console.WriteLine($"{this.date}/{this.time}, {dayOfTheWeekS}, {this.quantity} B, stay {CalcTime()}, {this.nameOfWeb}");
        }

        public int CalcAllData(Visit v)
        {
            return this.quantity + v.quantity;
        }
    }
}
