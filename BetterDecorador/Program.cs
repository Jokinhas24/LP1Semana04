using System;

namespace BetterDecorador
{
    public class Program
    {
        /// <summary>
        /// This method calls Decor with arguments given in the console
        /// </summary>
        /// <param name="args"> arguments used to call the decorator </param>
        private static void Main(string[] args)
        {
            Console.WriteLine(Decor(args[0], char.Parse(args[1]), int.Parse(args[2])));
        }
        /// <summary>
        /// This method decorates a string with a char a specific number of times around the string
        /// </summary>
        /// <param name="s"> decorated string </param>
        /// <param name="dec"> char that decorates</param>
        /// <param name="it"> how many times the char is repeated </param>
        /// <returns></returns>
        private static string Decor(string s, char dec, int it)
        {
            string decorators = new string(dec, it);
            return $"{decorators} {s} {decorators}";
        }
    }
}
