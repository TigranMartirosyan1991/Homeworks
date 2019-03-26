using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex_number
{
    class Complex
    {
        public double r, i;
        public Complex()
        {
            this.r = 0.0;
            this.i = 0.0;
        }
        public static Complex Sum(Complex a, Complex b)
        {
            Complex result = new Complex();
            result.r = a.r + b.r;
            result.i = a.i + b.i;
            return result;
        }
        public static Complex Multiplication(Complex a, Complex b)
        {
            Complex result = new Complex();
            result.r = a.r * b.r - a.i * b.i;
            result.i = a.i * b.r + a.r * b.i;
            return result;
        }
        public static Complex Subtract(Complex a, Complex b)
        {
            Complex result = new Complex();
            result.r = a.r - b.r;
            result.i = a.i - b.i;
            return result;
        }
        public static Complex Division(Complex a, Complex b)
        {
            Complex result = new Complex();
            result.r = a.r * b.r + a.i * b.i / b.r * b.r + b.i * b.i;
            result.i = a.i * b.r - a.r * b.i / b.r * b.r + b.i * b.i;
            return result;
        }
     
        public static Complex operator +(Complex a, Complex b)
        {
            return Complex.Sum(a, b);
        }
        public static Complex operator * (Complex a,Complex b)
        {
            return Complex.Multiplication(a,b);
        }
        public static Complex  operator / (Complex a,Complex b)
        {
            return Complex.Division(a, b);
        }
        public static  Complex operator - (Complex a,Complex b)
        {
            return Complex.Subtract(a, b);
        }
        public override string ToString()
        {
            return String.Format("{0} + i{1}", this.r, this.i);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex();
            Complex c2 = new Complex();
            c1.r = 5;
            c1.i = 3;
            c2.r = 7;
            c2.i = 9;
            Complex Sum = c1 + c2;
            Console.WriteLine(" new complex number is :{0}", Sum);
            Console.ReadKey();


        }
    }
}
