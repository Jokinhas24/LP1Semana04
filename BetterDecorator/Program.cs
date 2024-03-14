using System;

namespace BetterDecorator
{
    class Program
    {
        private static string Decor(string s, char dec)
        {
            return $"{dec}{dec}{dec} {s} {dec}{dec}{dec}";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Decor("Good Morning!", '*'));
            Console.WriteLine(Decor("Good Morning!", '.'));
        }
    }
}
