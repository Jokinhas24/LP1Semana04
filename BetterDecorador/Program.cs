using System;

namespace BetterDecorador
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Decor(args[0], char.Parse(args[1]), int.Parse(args[2])));
        }

        private static string Decor(string s, char dec, int it)
        {
            string decorators = new string(dec, it);
            return $"{decorators} {s} {decorators}";
        }
    }
}
