using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DayChallenge.Net.Day5
{
    public static class WhileLoop
    {
        /// <summary>
        /// Outputs
        /// 2
        /// 5
        /// 8
        /// 2
        /// 7
        /// </summary>
        public static void DoWhileLoopExample()
        {
            Random random = new Random();
            int current = 0;

            do
            {
                current = random.Next(1, 11);
                Console.WriteLine(2*current);
            } while (current != 10);

            Console.WriteLine("------------------------------");
        }

        /// <summary>
        /// Outputs
        /// 9
        /// 7
        /// 5
        /// Last number: 1
        /// </summary>
        public static void WhileLoopExample()
        {
            Random random = new Random();
            int current = random.Next(1, 11);

            while (current >= 5)
            {
                Console.WriteLine(2*current);
                current = random.Next(1, 11);
            }
            Console.WriteLine($"Last number: {current}");
            Console.WriteLine("------------------------------");
        }

        /// <summary>
        /// Outputs
        /// 5
        /// 1
        /// 6
        /// 7
        /// </summary>
        public static void ContinueDoWhileLoopExample()
        {
            Random random = new Random();
            int current = 0;

            do
            {
                current = random.Next(1, 11);

                if (current <= 5) continue;

                Console.WriteLine(2 * current);
            } while (current != 7);

            Console.WriteLine("------------------------------");
        }
    }
}
