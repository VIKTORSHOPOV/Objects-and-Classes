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
            set;get;
        }
        public string Author
        {
            set;get;
        }
        public int Year
        {
            set;get;
        }
        public int Count
        {
            set
            {
                if(value >= 0)
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
    }
}
