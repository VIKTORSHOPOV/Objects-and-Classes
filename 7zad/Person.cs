using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7zad
{
    class Person
    {
        private char sex;
        private int age;
        private string name;
        public char Sex
        {
            set
            {
                if (value == 'm' || value == 'f' || value == 'M' || value == 'F')
                {
                    this.sex = value;
                }
                else
                {
                    Console.WriteLine("Invalid data!");
                }
            }
            get { return this.sex; }
        }
        public int Age
        {
            set
            {
                if (value >= 0)
                {
                    this.age = value;
                }
                else
                {
                    Console.WriteLine("Invalid data!");
                }
            }
            get { return this.age; }
        }
        public string Name
        {
            set
            {
                if (value.Length > 0)
                {
                    this.name = value;
                }
                else
                {
                    Console.WriteLine("Invalid data!");
                }
            }
            get { return this.name; }
        }
    }
}
