using System;

namespace _4Pet
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfPet = Console.ReadLine();
            string type = Console.ReadLine();
            int ageInMonths = int.Parse(Console.ReadLine());
            string nameOfOwner = Console.ReadLine();
            string vaccinated = Console.ReadLine(); //(Yes/No)
            Pet p1 = new Pet(nameOfPet, type, ageInMonths, nameOfOwner, vaccinated);
            p1.MyPetInfo();

            nameOfPet = Console.ReadLine();
            type = Console.ReadLine();
            ageInMonths = int.Parse(Console.ReadLine());
            nameOfOwner = Console.ReadLine();
            vaccinated = Console.ReadLine(); //(Yes/No)
            Pet p2 = new Pet(nameOfPet, type, ageInMonths, nameOfOwner, vaccinated);
            p2.MyPetInfo();

            if (p1.Type == p2.Type)
            {
                if (p1.AgeInMonths > p2.AgeInMonths)
                {
                    Console.WriteLine($"{p1.NameOfPet} is {p1.CalcDiff(p2)} months older than {p2.NameOfOwner}");
                }
                else
                {
                    Console.WriteLine($"{p2.NameOfPet} is {p1.CalcDiff(p2)} months older than {p1.NameOfOwner}");
                }
            }
        }
    }
}
