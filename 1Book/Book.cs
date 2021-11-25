using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Book
{
    class Book
    {
        string title;
        string author;
        int year;
        int count;
        double price;

        public string Title
        {
            set; get;
        }
        public string Author
        {
            set; get;
        }
        public int Year
        {
            set; get;
        }
        public int Count
        {
            set
            {
                if (value >= 0)
                {
                    count = value;
                }
            }
            get { return count; }
        }
        public double Price
        {
            set
            {
                if (value >= 0)
                {
                    price = value;
                }
            }
            get { return price; }
        }

        public Book()
        {
            title = "";
            author = "";
            year = 0;
            count = 0;
            price = 0;
        }

        public Book(string title, string author, int year, int count, double price)
        {
            this.title = title;
            this.author = author;
            this.year = year;
            this.count = count;
            this.price = price;
        }

        public Book(Book t)
        {
            this.title = t.title;
            this.author = t.author;
            this.year = t.year;
            this.count = t.count;
            this.price = t.price;
        }

        public void WriteBook()
        {
            Console.WriteLine($"{title}, {year}, {author}, {count}");
        }
        public double CalcAll()
        {
            return count * price;
        }

    }
}
