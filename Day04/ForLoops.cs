using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DayChallenge.Net.Day4
{
    public static class ForLoops
    {
        /// <summary>
        /// Outputs
        /// 0
        /// 1
        /// 2
        /// 3
        /// 4
        /// 5
        /// 6
        /// 7
        /// 8
        /// 9
        /// 10
        /// </summary>
        public static void ForLoopExample()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"Number {i}");
            }

            Console.WriteLine("------------------------------");
        }

        /// <summary>
        /// Outputs
        /// 10
        /// 9
        /// 8
        /// 7
        /// 6
        /// 5
        /// 4
        /// 3
        /// 2
        /// 1
        /// </summary>
        public static void BackwardForLoopExample()
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine($"Number {i}");
            }

            Console.WriteLine("------------------------------");
        }

        /// <summary>
        /// Outputs
        /// 3
        /// 6
        /// 0
        /// 9
        /// </summary>
        public static void IterationForLoopExample()
        {
            for (int i = 0; i < 20; i += 5)
            {
                Console.WriteLine($"Number {i}");
            }

            Console.WriteLine("------------------------------");
        }

        /// <summary>
        /// Outputs
        /// 0
        /// 1
        /// 2
        /// 3
        /// 4
        /// 5
        /// 6
        /// 7
        /// </summary>
        public static void BreakForLoopExample()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Number {i}");
                if (i == 6) break;
            }

            Console.WriteLine("------------------------------");
        }

        public static void BreakingAndIteratingForLoopExample()
        {
            for (int i = 0; i < 10; i+=3)
            {
                Console.WriteLine($"Number {i}");
                if (i == 7) break;
            }
            Console.WriteLine("Loop iterating in 3, 6, 9 pattern. If i equals to 7, the loops break, otherwise continue as the condition fulfilled.");
            Console.WriteLine("------------------------------");
        }

        public static void ForLoopWithContinue()
        {
            for (int i = 0; i < 10; i++)
            {
                //if (i == 7) continue;
                Console.WriteLine($"Number {i}");
            }
            Console.WriteLine("------------------------------");
        }
    }
}
