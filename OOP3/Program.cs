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
            Console.WriteLine(c);
            c.ReduceFraction();
            Console.WriteLine(c);
            Fraction d = c - a;
            Console.WriteLine(d);
            Fraction e = new Fraction(2, 4);
            d = e * c;
            Console.WriteLine(d);
            d.ReduceFraction();
            Console.WriteLine(d);
            d /= c;
            Console.WriteLine(d);
            Console.WriteLine(d == c);
            Console.WriteLine(d != c);
            Console.WriteLine(d >= c);
            Console.WriteLine(b <= c);
            d = +d;
            d = -d;
            Console.WriteLine(d);
            double r = (double)c;
            Console.WriteLine(r);
        }
        
    }
}
