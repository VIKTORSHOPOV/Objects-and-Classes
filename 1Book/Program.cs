using System;

namespace _1Book
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string auhtor = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            Book book1 = new Book(title, auhtor, year, count, price);
            book1.WriteBook();

            title = Console.ReadLine();
            auhtor = Console.ReadLine();
            year = int.Parse(Console.ReadLine());
            count = int.Parse(Console.ReadLine());
            price = double.Parse(Console.ReadLine());
            Book book2 = new Book(title, auhtor, year, count, price);
            book2.WriteBook();

            Console.WriteLine(book1.Year > book2.Year ? book2.CalcAll() : book1.CalcAll());

        }
    }
}
