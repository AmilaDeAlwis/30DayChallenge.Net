using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DayChallenge.Net.Day10
{
    public static class FilePath
    {
        /// <summary>
        /// Outputs
        /// D:\Workspace\30DayChallenge.Net\30DayChallenge.Net\bin\Debug\net8.0
        /// </summary>
        public static void DisplayCurrentDirectory()
        {
            Console.WriteLine($"Get the directory of this file: {Directory.GetCurrentDirectory()}");
            Console.WriteLine("------------------------------");
        }

        /// <summary>
        /// Outputs
        /// C:\Users\admin\Documents
        /// </summary>
        public static void DisplaySpecialDirectory()
        {
            Console.WriteLine($"Get the MyDocument folder location: {Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}");
            Console.WriteLine("------------------------------");
        }

        /// <summary>
        /// Outputs
        /// For windows: \sample        
        /// </summary>
        public static void DisplayOSPathCharacters()
        {
            Console.WriteLine($"For windows: {Path.DirectorySeparatorChar} is the seperator character");
            Console.WriteLine("------------------------------");
        }

        /// <summary>
        /// Outputs
        /// .json
        /// </summary>
        public static void DisplayFileExtension()
        {
            Console.WriteLine(Path.GetExtension("sample.json"));
        }
    }
}
