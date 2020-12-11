using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace OOP3
{
    class Fraction
    {
        protected int Numerator { set; get; }
        protected int Denominator { set; get; }
        public Fraction()
        {
            Numerator = 0;
            Denominator = 0;
        }
        public Fraction(int num, int den)
        {
            Numerator = num;
            Denominator = den;
        }
        public Fraction(string str)
        {
            Regex check = new Regex(@"(\d+)\/(\d+)");
            Match match = check.Match(str);
            Numerator = int.Parse(match.Groups[1].Value);
            Denominator = int.Parse(match.Groups[2].Value);
        }
        public Fraction(int num)
        {
            Numerator = num;
            Denominator = 1;
        }
        public static int GCD(int a, int b)
        {
            if (b == 0)
                return a;
            return GCD(b, a % b);
        }
        public static int LCM(int a, int b)
        {
            int temp = GCD(a, b);

            return (a / temp * b);
        }
        public static Fraction operator +(Fraction fract1, Fraction fract2)
        {
            
            int Den = LCM(fract1.Denominator, fract2.Denominator);
            int num1 = fract1.Numerator * (Den / fract1.Denominator);
            int num2 = fract2.Numerator * (Den / fract2.Denominator);
            Fraction res = new Fraction((num1 + num2), Den);
            return res;
        }
        public static Fraction operator -(Fraction fract1, Fraction fract2)
        {

            int Den = LCM(fract1.Denominator, fract2.Denominator);
            int num1 = fract1.Numerator * (Den / fract1.Denominator);
            int num2 = fract2.Numerator * (Den / fract2.Denominator);
            Fraction res = new Fraction((num1 - num2), Den);
            return res;
        }
        public static Fraction operator *(Fraction fract1, Fraction fract2)
        {
            Fraction res = new Fraction((fract1.Numerator * fract2.Numerator),
                (fract1.Denominator * fract2.Denominator));
            return res;
        }
        public static Fraction operator /(Fraction fract1, Fraction fract2)
        {
            Fraction res = new Fraction((fract1.Numerator * fract2.Denominator),
                (fract1.Denominator * fract2.Numerator));
            return res;
        }
        public static bool operator >(Fraction fract1, Fraction fract2)
        {
            int Den = LCM(fract1.Denominator, fract2.Denominator);
            int num1 = fract1.Numerator * (Den / fract1.Denominator);
            int num2 = fract2.Numerator * (Den / fract2.Denominator);
            if (num1 > num2) return true;
            else
                return false;
        }
        public static bool operator <(Fraction fract1, Fraction fract2)
        {
            int Den = LCM(fract1.Denominator, fract2.Denominator);
            int num1 = fract1.Numerator * (Den / fract1.Denominator);
            int num2 = fract2.Numerator * (Den / fract2.Denominator);
            if (num1 > num2) return false;
            else
                return true;
        }
        public static bool operator >=(Fraction fract1, Fraction fract2)
        {
            int Den = LCM(fract1.Denominator, fract2.Denominator);
            int num1 = fract1.Numerator * (Den / fract1.Denominator);
            int num2 = fract2.Numerator * (Den / fract2.Denominator);
            if (num1 >= num2) return true;
            else
                return false;
        }
        public static bool operator <=(Fraction fract1, Fraction fract2)
        {
            int Den = LCM(fract1.Denominator, fract2.Denominator);
            int num1 = fract1.Numerator * (Den / fract1.Denominator);
            int num2 = fract2.Numerator * (Den / fract2.Denominator);
            if (num1 <= num2) return true;
            else
                return false;
        }
        public static bool operator ==(Fraction fract1, Fraction fract2)
        {
            int Den = LCM(fract1.Denominator, fract2.Denominator);
            int num1 = fract1.Numerator * (Den / fract1.Denominator);
            int num2 = fract2.Numerator * (Den / fract2.Denominator);
            if (num1 == num2) return true;
            else
                return false;
        }
        public static bool operator !=(Fraction fract1, Fraction fract2)
        {
            int Den = LCM(fract1.Denominator, fract2.Denominator);
            int num1 = fract1.Numerator * (Den / fract1.Denominator);
            int num2 = fract2.Numerator * (Den / fract2.Denominator);
            if (num1 != num2) return true;
            else
                return false;
        }
        public static Fraction operator -(Fraction fract1)
        {
            fract1.Denominator = -fract1.Denominator;
            fract1.Numerator = -fract1.Numerator;
            return fract1;
        }
        public static Fraction operator +(Fraction fract1)
        {
            fract1.Denominator = +fract1.Denominator;
            fract1.Numerator = +fract1.Numerator;
            return fract1;
        }
        public static explicit operator double(Fraction fract1)
        {
            return fract1.Numerator * 1.0d / fract1.Denominator * 1.0d;
        }
        public void ReduceFraction()
        {
            int gcd = GCD(Numerator, Denominator);
            Numerator /= gcd;
            Denominator /= gcd;
        }
        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

    }
}
