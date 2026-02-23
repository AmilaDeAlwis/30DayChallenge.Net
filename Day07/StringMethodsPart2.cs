using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _30DayChallenge.Net.Day7
{
    public static class StringMethodsPart2
    {
        /// <summary>
        /// Outputs
        /// Searching THIS message: Help (find) the {opening symbols}
        /// Found WITHOUT using startPosition: (find) the { opening symbols }
        /// </summary>
        public static void IndexOfAnyMethod()
        {
            string message = "Get any of (the) the {defined symbols}";
            Console.WriteLine($"Normal string: {message}");
            char[] openSymbols = ['[', '{', '('];

            int openingPosition = message.IndexOfAny(openSymbols);
            Console.WriteLine($"Got a substring using the defined characters: {message.Substring(openingPosition)}");
            Console.WriteLine("------------------------------");

        }

        /// <summary>
        /// Outputs
        /// set of parentheses
        /// </summary>
        public static void LastIndexOfMethod() {

            string message = "(What if) I am (only interested) in the last (set of parentheses)?";
            int openingPosition = message.LastIndexOf('(');

            openingPosition += 1;
            int closingPosition = message.LastIndexOf(')');
            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));
        }
    }
}
