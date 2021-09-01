using System;
using System.CodeDom;
using System.Collections;
using System.IO;

namespace _4_MethodsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1
            string name = GetName();
            GreetFriend(name);

            //2
            double result1 = GetNumber();
            double result2 = GetNumber();
            int action1 = GetAction();
            double result3 = DoAction(result1, result2, action1);

            System.Console.WriteLine($"The result of your mathematical operation is {result3}.");
        }

        public static string GetName()
        {
            string name = Console.ReadLine();
            return name;

        }

        public static string GreetFriend(string name)
        {
            return $"Hello, {name}. You are my friend.";
        }

        public static double GetNumber()
        {
            Console.WriteLine("Enter a number: ");
            double inputNum;
            bool isNum = double.TryParse(Console.ReadLine(), out inputNum);

            if(!isNum)
            {
                throw new FormatException("Invalid input");
            }
            else { return inputNum; }
        }

        public static int GetAction()
        {
            Console.WriteLine("[1] ADD\n[2] \nSUBTRACT[3] \nMULTIPLY \n[4] DIVIDE ");
            int choice = int.Parse(Console.ReadLine());
            return choice;

        }

        public static double DoAction(double x, double y, int action)
        {
            double result;
            switch(action)
            {
                case 1:
                    result = x + y;
                    return result;
                case 2:
                    result = x - y;
                    return result;
                case 3:
                    result = x * y;
                    return result;
                case 4:
                    result = x / y;
                    return result;
                default:
                    throw new FormatException("Something went wrong");
            }
        }
    }
}
