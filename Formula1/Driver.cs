using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1
{
    class Driver
    {
        public string Name
        {
            set; get;
        }
        public int Age
        {
            set; get;
        }

        public double TotalTime
        {
            set; get;
        }

        public double Speed
        {
            set; get;
        }

        public Driver()
        {
            Name = "";
            Age = 0;
            TotalTime = 0;
            Speed = 0;
        }

        public Driver(string name, int age, double totaltime, double speed)
        {
            Name = name;
            Age = age;
            TotalTime = totaltime;
            Speed = speed;
        }

        public void ShowInfo()
        {

            Console.WriteLine($"DriverName: { Name } \nDriverAge: { Age }\n Time: { TotalTime } \nSpeed: { Speed } ");
        }
    }




}
