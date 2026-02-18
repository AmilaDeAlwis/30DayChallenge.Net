using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DayChallenge.Net.Day2
{
    public static class CodeBlocksAndScope
    {
        /// <summary>
        /// Output
        /// Inside the code block: 10
        /// </summary>
        public static void VariableInCodeBlock()
        {
            bool flag = true; // boolean flag
            if (flag)
            {
                Console.WriteLine("Variable scope starts from here");
                int value = 10;
                Console.WriteLine($"Inside the code block: {value}");
                Console.WriteLine("Variable scope end here");
                Console.WriteLine("------------------------------");
            }
        }

        /// <summary>
        /// Outputs
        /// Program.cs(7,46): error CS0103: The name 'value' does not exist in the current context
        /// </summary>
        public static void VariableOutCodeBlock()
        {
            bool flag = true;
            if (flag)
            {
                Console.WriteLine("Variable scope starts from here");
                int value = 10;
                Console.WriteLine($"Inside the code block: {value}");
                Console.WriteLine("Variable scope end here");
            }

            Console.WriteLine("Outside the code block");
            Console.WriteLine("If 'value' was called here, it consider as calling from outside the code block. Compiler error.");
            Console.WriteLine("------------------------------");
        }

        /// <summary>
        /// Outputs
        /// Program.cs(6,49): error CS0165: Use of unassigned local variable 'value'
        /// </summary>
        public static void VariableAboveCodeBlock()
        {
            bool flag = true;
            int value; // No value assigned. Declared only.

            if (flag)
            {
                Console.WriteLine("Variable scope starts from here");
                Console.WriteLine("'value' variable can't access within the code block. Compiler error.");
                Console.WriteLine("Variable scope end here");
            }

            value = 10;
            Console.WriteLine($"Outside the code block: {value}");
            Console.WriteLine("------------------------------");
        }

        /// <summary>
        /// Outputs
        /// Inside the code block: 0
        /// Outside the code block: 10
        /// </summary>
        /// <returns></returns>
        public static void VariableAboveCodeBlockv1()
        {
            bool flag = true;
            int value = 0; // Value assigned. Default value is 0.

            if (flag)
            {
                Console.WriteLine("Variable scope starts from here");
                Console.WriteLine($"Variable is initialized. Inside the code block: {value}");
                Console.WriteLine("Variable scope end here");
            }

            value = 10;
            Console.WriteLine($"Outside the code block: {value}");
            Console.WriteLine("------------------------------");
        }
    }

}
