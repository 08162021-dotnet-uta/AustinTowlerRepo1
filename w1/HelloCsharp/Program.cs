using System;

namespace HelloCsharp
{
    class Program
    {
        //build a simple calculator using 5 methods: add, mulitply, subtract, divide, print
        double total;
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first number: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your second number: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Which operation do you want to perfrom? Enter one: [+, -, *,/]");
            string op = Console.ReadLine();

            if(op == "+")
            {
                Program p = new Program();
                p.add(a, b);
            }
            else if(op == "-")
            {
                Program p = new Program();
                p.subtract(a, b);
            }
            else if(op == "*")
            {
                Program p = new Program();
                p.mult(a, b);
            }
            else if(op == "/")
            {
                Program p = new Program();
                p.divide(a, b);
            }
            else
            {
                Console.WriteLine("Invalid operator");
            }

        }

        public void print()
        {
            Console.WriteLine("Answer: " + total);
        }

        public void add(double one, double two)
        {
            total = one + two;
            print();
        }

        public void subtract(double one, double two)
        {
            total = one - two;
            print();
        }

        public void mult(double one, double two)
        {
            total = one * two;
            print();
        }

        public void divide(double one, double two)
        {
            total = one / two;
            print();
        }




    }
}
