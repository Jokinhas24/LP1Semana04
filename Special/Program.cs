using System;
using System.Xml.XPath;

namespace Special
{
    class Program
    {
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
        static void Main(string[] args)
        {
            Console.Write("Insert n-th number of the special sequence: ");
            string ns = Console.ReadLine();
            int n = int.Parse(ns);

            Console.Write(GetSpecial(n));
        }
    }
}
