using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DayChallenge.Net.Day3
{
    public static class Switch
    {
        static int employeeLevel = 400;
        static string employeeName = "Amila De Alwis";

        /// <summary>
        /// Outputs
        /// Amila De Alwis, Senior Manager
        /// </summary>
        public static void SwitchExample()
        {
            string title = "";
            string salary = "";

            switch (employeeLevel)
            {
                case 100:
                    title = "Junior Associate";
                    salary = "$50,000";
                    break;
                case 200:
                    title = "Senior Associate";
                    salary = "$70,000";
                    break;
                case 300:
                    title = "Manager";
                    salary = "$90,000";
                    break;
                case 400:
                    title = "Senior Manager";
                    salary = "$110,000";
                    break;
                default:
                    title = "Associate";
                    salary = "$60,000";
                    break;
            }

            Console.WriteLine($"{employeeName} is a {title} that earns {salary}");
            Console.WriteLine("------------------------------");
        }

        /// <summary>
        /// Amila De Alwis, Associate
        /// </summary>
        public static void ChangeSwitchLabelExample()
        {
            employeeLevel = 201;
            employeeName = "Gimhana De Alwis";
            SwitchExample();
        }

        /// <summary>
        /// Outputs
        /// John Smith, Senior Associate
        /// </summary>
        public static void MultipleSwitchLabelExample()
        {
            int employeeLevel = 100;
            string employeeName = "John Smith";

            string title = "";

            switch (employeeLevel)
            {
                case 100:
                case 200:
                    title = "Senior Associate";
                    break;
                case 300:
                    title = "Manager";
                    break;
                case 400:
                    title = "Senior Manager";
                    break;
                default:
                    title = "Associate";
                    break;
            }

            Console.WriteLine($"{employeeName}, {title}");
        }
    }
}
