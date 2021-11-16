using System;

namespace _3._1School
{
    class Program
    {
        static void Main(string[] args)
        {
            School school = new School();

            school.name = Console.ReadLine();
            school.adress = Console.ReadLine();
            school.phoneNumber = Console.ReadLine();
            school.website = Console.ReadLine();

            Console.WriteLine("1.School name: ");
            Console.WriteLine("2.School adress: ");
            Console.WriteLine("3.School phone number: ");
            Console.WriteLine("4.School website:  ");
            Console.WriteLine("5.I ran out of questions.");

            var number = int.Parse(Console.ReadLine());
            while (number != 5)
            {
                switch (number)
                {
                    case 1: Console.WriteLine(school.name); break;
                    case 2: Console.WriteLine(school.adress); break;
                    case 3: Console.WriteLine(school.phoneNumber); break;
                    case 4: Console.WriteLine(school.website); break;
                    case 5: break;
                    default:
                        break;
                }
                number = int.Parse(Console.ReadLine());
            }

        }
    }
}
