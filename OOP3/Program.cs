using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction a = new Fraction("1/3");
            Fraction b = new Fraction(1,6);
            Fraction c = a + b;
            Console.WriteLine(c.ToString());
            c.ReduceFraction();
            Console.WriteLine(c.ToString());
            Fraction d = c - a;
            Console.WriteLine(d.ToString());
            Fraction e = new Fraction(2, 4);
            d = e * c;
            Console.WriteLine(d.ToString());
            d.ReduceFraction();
            Console.WriteLine(d.ToString());
            d /= c;
            Console.WriteLine(d.ToString());
            Console.WriteLine(d == c);
            Console.WriteLine(d != c);
            Console.WriteLine(d >= c);
            Console.WriteLine(b <= c);
            d = +d;
            d = -d;
            Console.WriteLine(d.ToString());
            double r = (double)c;
            Console.WriteLine(r);
        }
        
    }
}
