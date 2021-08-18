using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Convert.ToInt16(Console.ReadLine());
            var b = Convert.ToInt16(Console.ReadLine());
           
            add(a, b);
            subtract(a, b);
            mult(a, b);
            divide(a, b);
        }

        static void print(int total)
        {
            Console.WriteLine(total);
        }
        static void add(int a, int b)
        {
            var total = a + b;
            print(total);
        }

        static void subtract(int a, int b)
        {
            var total = a - b;
            print(total);
        }

        static void mult(int a, int b)
        {
            var total = a * b;
            print(total);
        }

        static void divide(int a, int b)
        {
            var total = a / b;
            print(total);
        }
    }
}
