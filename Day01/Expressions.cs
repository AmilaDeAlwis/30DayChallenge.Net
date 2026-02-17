using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DayChallenge.Net.Day1
{
    public static class Expressions
    {
        /// <summary>
        /// Outputs
        /// True
        /// False
        /// False
        /// True
        /// </summary>
        //public static void CheckEqualityOperator()
        //{
        //    Console.WriteLine("a" == "a");
        //    Console.WriteLine("a" == "A");
        //    Console.WriteLine(1 == 2);
        //    Console.WriteLine("a" == " a");

        //    string myValue = "a";
        //    Console.WriteLine(myValue == "a");
        //}

        public static void CheckEqualityOperator()
        {
            Console.WriteLine("Method 01: Check Equality Operator");
            string v1 = "a";
            string v2 = "b";
            Console.WriteLine(v2 == "b");
            Console.WriteLine("b" == v2.ToUpper());
            Console.WriteLine(2 == 2);
            Console.WriteLine(v1.ToUpper() == v2.ToUpper());
            Console.WriteLine("------------------------------");
        }

        /// <summary>
        /// Outputs
        /// True
        /// </summary>
        //public static void CheckEqualityBuiltInMethods() {
        //    string value1 = " a";
        //    string value2 = "A ";
        //    Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
        //}

        public static void CheckVariableEqualityUsingBuiltInMethods()
        {
            Console.WriteLine("Method 02: Check Equality Using Built-In Methods");
            string value1 = "mynameis Summer";
            string value2 = "my NAME is SumMEr";
            Console.WriteLine(value1.Trim().ToUpper() == value2.Trim().ToUpper());
            Console.WriteLine("------------------------------");
        }

        /// <summary>
        /// Outputs
        /// False
        /// True
        /// True
        /// False
        /// </summary>
        //public static void CheckInEqualityOperator()
        //{
        //    Console.WriteLine("a" != "a");
        //    Console.WriteLine("a" != "A");
        //    Console.WriteLine(1 != 2);

        //    string myValue = "a";
        //    Console.WriteLine(myValue != "a");
        //}

        public static void CheckNotEqualOperator()
        {
            Console.WriteLine("Method 03: Check Not Equal moments");
            int v1 = 1;
            int v2 = 2;
            Console.WriteLine(v1 != v2);
            Console.WriteLine(v1+1 != v2);
            Console.WriteLine(v1*2 != v2);
            Console.WriteLine("------------------------------");
        }

        /// <summary>
        /// Outputs
        /// False
        /// True
        /// True
        /// True
        /// </summary>
        public static void CheckComparisonOperator()
        {
            Console.WriteLine(1 > 2);
            Console.WriteLine(1 < 2);
            Console.WriteLine(1 >= 1);
            Console.WriteLine(1 <= 1);
        }

        /// <summary>
        /// Check if method contains a substring
        /// </summary>
        public static void CheckBooleanMethods()
        {
            string pangram = "The quick brown fox jumps over the lazy dog.";
            Console.WriteLine(pangram.Contains("fox"));
            Console.WriteLine(pangram.Contains("cow"));
        }
    }
}
