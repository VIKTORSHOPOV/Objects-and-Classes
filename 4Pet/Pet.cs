using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Pet
{
    class Pet
    {
        string nameOfPet;
        string type;
        int ageInMonths;
        string nameOfOwner;
        string vaccinated; //(Yes/No)

        public string NameOfPet { get; set; }
        public string Type { get; set; }
        public int AgeInMonths { get { return ageInMonths; } set { if (value >= 0) ageInMonths = value; } }
        public string NameOfOwner { set; get; }
        public string Vaccinated { get { return vaccinated; } set { if (value == "Yes" || value == "No") vaccinated = value; } }

        public Pet()
        {
            nameOfPet = "";
            type = "";
            ageInMonths = 0;
            nameOfOwner = "";
            vaccinated = "";
        }

        public Pet(string nameOfPet, string type, int ageInMonths, string nameOfOwner, string vaccinated)
        {
            this.nameOfPet = nameOfPet;
            this.type = type;
            this.ageInMonths = ageInMonths;
            this.nameOfOwner = nameOfOwner;
            this.vaccinated = vaccinated;
        }

        public Pet(Pet p)
        {
            nameOfPet = p.nameOfPet;
            type = p.type;
            ageInMonths = p.ageInMonths;
            nameOfOwner = p.nameOfOwner;
            vaccinated = p.vaccinated;
        }

        public void MyPetInfo()
        {
            Console.WriteLine((vaccinated == "Yes") ? 
                $"{NameOfPet} – {ageInMonths}, {ageInMonths / 12} {ageInMonths % 12} (в години и месеци), {nameOfOwner}, vaccinated":
                $"{NameOfPet} – {ageInMonths}, {ageInMonths / 12} {ageInMonths % 12} (в години и месеци), {nameOfOwner}, unvaccinated");
        }

        public int CalcDiff(Pet p)
        {
            if(this.type == p.type)
            {
                return Math.Abs(this.ageInMonths - p.ageInMonths);
            }
            return 0;
        }
    }
}
