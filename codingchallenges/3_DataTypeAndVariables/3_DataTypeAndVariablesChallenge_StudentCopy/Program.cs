using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace _3_DataTypeAndVariablesChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string numString = "134654";
            string failNumString = "135a546";
            int testInt = 250;
            double testDouble = 32.02;
            float testFloat = 32.123f;

            Console.WriteLine(PrintValues(testInt));
            Console.WriteLine(PrintValues(testDouble));
            Console.WriteLine(PrintValues(testFloat));

            Console.WriteLine(StringToInt(numString));
            Console.WriteLine(StringToInt(failNumString));
        }

        /// <summary>
        /// This method has an 'object' type parameter. 
        /// 1. Create a switch statement that evaluates for the data type of the parameter
        /// 2. You will need to get the data type of the parameter in the 'case' part of the switch statement
        /// 3. For each data type, return a string of exactly format, "Data type => <type>" 
        /// 4. For example, an 'int' data type will return ,"Data type => int",
        /// 5. A 'ulong' data type will return "Data type => ulong",
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string PrintValues(object obj)
        {
            switch(obj)
            {
                case int aInt:
                    return "Data type => int";

                case double aDouble:
                    return "Data type => double";

                case float aFlout:
                    return "Data type => float";

                default:
                    return "No type found";
            }
        }

        /// <summary>
        /// THis method has a string parameter.
        /// 1. Use the .TryParse() method of the Int32 class (Int32.TryParse()) to convert the string parameter to an integer. 
        /// 2. You'll need to investigate how .TryParse() and 'out' parameters work to implement the body of StringToInt().
        /// 3. If the string cannot be converted to a integer, return 'null'. 
        /// 4. Investigate how to use '?' to make non-nullable types nullable.
        /// </summary>
        /// <param name="numString"></param>
        /// <returns></returns>
        public static int? StringToInt(string numString)
        {
            int result;
            bool isValid;

            isValid = int.TryParse(numString, out result);
            if(!isValid)
            {
                Console.WriteLine("cannot be converted");
                return null;
            }
            else
            {
                return result;
            }
        }
    }// end of class
}// End of Namespace
