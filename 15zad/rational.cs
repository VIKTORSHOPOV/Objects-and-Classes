using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15zad
{
    class Rational
    {
        int num;
        int denum;
        public int Num
        {
            set; get;
        }
        public int Denum
        {
            set; get;
        }

        public Rational()
        {
            num = 0;
            denum = 1;
        }
        public Rational(int num, int denum)
        {
            this.num = num;
            this.denum = denum;
        }
        public Rational(Rational r)
        {
            num = r.num;
            denum = r.denum;
        }
        public void Add(Rational r)
        {
            num = num * r.denum + r.num * denum;
            denum = denum * r.denum;
        }
        public void Sub(Rational r)
        {
            num = num * r.denum - r.num + denum;
            denum = denum * r.denum;
        }
        public void Mult(Rational r)
        {
            num = num * r.num;
            denum = denum * r.denum;
        }
        public void Div(Rational r)
        {
            num = num * r.denum;
            denum = denum * r.num;
        }
        public double compare(Rational r)
        {
            if (num * r.denum > r.num * denum)
            {
                return 1;
            }
            if (num * r.denum < r.num * denum)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        public void Print()
        {
            Console.WriteLine($"{num}/{denum}");
        }
    }
}
