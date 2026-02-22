using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DayChallenge.Net.Day6
{
    public static class StringMethods
    {
        /// <summary>
        /// Outputs
        /// 13
        /// 36
        /// </summary>
        public static void IndexOfExample()
        {
            string message = "Find what is (inside the parentheses)";

            int openingPosition = message.IndexOf('('); // get the index of the opening parentheses
            int closingPosition = message.IndexOf(')'); // get the index of the closing parentheses

            Console.WriteLine(openingPosition);
            Console.WriteLine(closingPosition);
            Console.WriteLine("------------------------------");
        }

        /// <summary>
        /// Outputs
        /// (inside the parentheses
        /// </summary>
        public static void SubstringExample()
        {
            string message = "Find what is (inside the parentheses)";

            int openingPosition = message.IndexOf('(');
            int closingPosition = message.IndexOf(')');

            int length = closingPosition - openingPosition-1;
            Console.WriteLine(message.Substring(openingPosition+1, length));
            Console.WriteLine("------------------------------");
        }

        /// <summary>
        /// Outputs
        /// inside the parentheses
        /// </summary>
        public static void SubstringExample2()
        {
            Console.WriteLine("More clean way to get the text inside the parentheses");
            string message = "Find what is (inside the parentheses)";

            int openingPosition = message.IndexOf('(');
            int closingPosition = message.IndexOf(')');

            openingPosition += 1;

            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));
        }
    }
}
