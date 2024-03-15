using System;
using System.Xml.XPath;

namespace Special
{
    class Program
    {
        /// <summary>
        /// This method receives a set number then return the n-th of the
        /// special sequence
        /// </summary>
        /// <param name="n">
        /// Number of the special sequence
        /// </param>
        /// <returns></returns>
        private static int GetSpecial(int n)
        {
            int result = 0;

            if (n == 0)
            {
                result = 0;
            }
            else if (n == 1)
            {
                result = 1;
            }
            else
            {
                result = GetSpecial(n - 1) + 2 * GetSpecial(n - 2);
            }

            return result;
        }    
        /// <summary>
        /// This method is the main method, it starts the code, converts the
        /// string into a integer then runs the other method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Insert n-th number of the special sequence: ");
            string ns = Console.ReadLine();
            int n = int.Parse(ns);

            Console.Write(GetSpecial(n));
        }
    }
}
