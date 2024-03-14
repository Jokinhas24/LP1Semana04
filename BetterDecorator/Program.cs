using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;

namespace BetterDecorator
{
    class Program
    {
        /// <summary>
        /// This method reads a string, a char and a int and return the string
        /// between int times the char given
        /// </summary>
        /// <param name="s">
        /// the main string
        /// </param>
        /// <param name="dec">
        /// char that decorates
        /// </param>
        /// <param name="it">
        /// how many times the char appears
        /// </param>
        /// <returns></returns>
        private static string Decor(string s, char dec, int it)
        {
            string result = s;

            for (int x = 0; x < it; x++)
            {
                result = $"{dec}{result}{dec}";
            }

            return result;
        }
        static void Main(string[] args)
        {
            char arg2 = char.Parse(args[1]);
            int arg3 = int.Parse(args[2]);

            Console.WriteLine(Decor(args[0], arg2, arg3));
        }
    }
}
