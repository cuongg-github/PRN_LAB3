using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    interface IBasic<T> where T: struct
    {
        T add ( T a, T b );
        T subtraction ( T a, T b );
        T multiplication ( T a, T b );
        T division ( T a, T b );

    }
    class Myclass : IBasic<double>
    {
        public double add ( double a, double b ) => a + b;
        public double subtraction (double a, double b ) => a - b;
        public double multiplication(double a, double b ) => a * b;
        public double division(double a, double b )
        {
            if ( b == 0 )
            {
                return 0;
            }
            return a / b;
        }
    }
    internal class Q1
    {
        static void Main(string[] args)
        {
            Myclass myclass = new Myclass();
            double i = myclass.add(4.5, 3.3);
            Console.WriteLine($"addition between 4.5 and 3.3 is {i}");
            i = myclass.subtraction(2.3, 1.2);
            Console.WriteLine($"subtraction between 2.3 and 1.2 is {i}");
            i = myclass.multiplication(6.4, 3.2);
            Console.WriteLine($"multiplication between 6.4 and 3.2 is {i}");
            i = myclass.division(4, 0);
            Console.WriteLine($"division between 4 and 0 is {i}");
            i = myclass.division(4, 3);
            Console.WriteLine($"division between 4 and 3 is {i}");
        }
    }
}
