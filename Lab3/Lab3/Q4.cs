using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{

    internal class Q4
    {
        public static void swap<T>( ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int a = 2, b = 3;
            Console.WriteLine($"<int> a = {a} and b = {b}");
            swap<int>( ref a, ref  b);
            Console.WriteLine($"<int> after swap a = {a} = {b}");
            string str1 = "cuongtq", str2 = "de181075";
            Console.WriteLine($"<string> str1 ({str1}) and str2 ({str2})");
            swap<string>( ref str1, ref str2);
            Console.WriteLine($"<string> after swap str1 ({str1}) and str2 ({str2})");

        }
    }
}
