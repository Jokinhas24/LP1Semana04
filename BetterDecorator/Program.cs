using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;

namespace BetterDecorator
{
    class Program
    {
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
