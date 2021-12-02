using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1
{
    class Team
    {

        public string TeamName
        {
            get; set;
        }
        public Driver Pilot1
        {
            get; set;
        }
        public Driver Pilot2
        {
            get; set;
        }

        public Team()
        {
            TeamName = "";
            Pilot1 = new Driver();
            Pilot2 = new Driver();
        }
        public Team(string teamName, Driver pilot1, Driver pilot2)
        {
            TeamName = teamName;
            Pilot1 = new Driver();
            Pilot1.Name = pilot1.Name;
            Pilot1.Age = pilot1.Age;
            Pilot1.TotalTime = pilot1.TotalTime;
            Pilot1.Speed = pilot1.Speed;

            Pilot2 = new Driver();
            Pilot2.Name = pilot2.Name;
            Pilot2.Age = pilot2.Age;
            Pilot2.TotalTime = pilot2.TotalTime;
            Pilot2.Speed = pilot2.Speed;

        }

        public void ShowInfo1()
        {

            Console.WriteLine($"Team: { TeamName }");
            Pilot1.ShowInfo();


        }
        public void ShowInfo2()
        {

            Console.WriteLine($"Team: { TeamName }");
            Pilot2.ShowInfo();


        }




    }
}
