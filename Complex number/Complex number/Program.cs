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
        public static Complex Sum(Complex a,Complex b)
        {
            Complex result = new Complex();
            result.r = a.r + b.r;
            result. i = a.i + b.i;
            return result;
        }
        public static  Complex Multiplication (Complex a,Complex b)
        {
            Complex result = new Complex();
            result.r = a.r * b.r- a.i * b.i;
            result.i = a.i * b.r + a.r *b.i;
            return result;
        }
        public static Complex Subtract ( Complex a,Complex b)
        {
            Complex result = new Complex();
            result.r = a.r - b.r;
            result.i = a.i - b.i;
            return result;
        }
        public  static Complex Division ( Complex a,Complex b)
        {
            Complex result = new Complex();
            result.r = a.r * b.r + a.i * b.i / b.r * b.r + b.i * b.i;
            result.i = a.i * b.r - a.r * b.i / b.r * b.r + b.i * b.i;
            return result;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
