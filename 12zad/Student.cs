using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12zad
{
    class Student
    {
        private string name;
        private int nomer;
        private string spec;
        private int kurs;
        public Student()
        {
            name = "";
            nomer = 0;
            spec = "";
            kurs = 0;
        }
        public Student(string name, int n, string s, int k)
        {
            this.name = name;
            this.nomer = n;
            this.spec = s;
            this.kurs = k;
        }
        public Student(Student stud)
        {
            name = stud.name;
            nomer = stud.nomer;
            spec = stud.spec;
            kurs = stud.kurs;
        }
        public void print()
        {
            Console.Write($"{name}, {nomer}, {spec}, {kurs}");
        }
    }
}
