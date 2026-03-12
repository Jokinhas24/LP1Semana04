using System;

namespace BetterDecorador
{
    public class Program
    {
        /// <summary>
        /// This method calls Decor with arguments given in the console,
        /// if there are none it calls it without them.
        /// </summary>
        /// <param name="args"> Arguments used to call the decorator. </param>
        private static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine(Decor());
            }
            else
            {
                Console.WriteLine(Decor(args[0], char.Parse(args[1]), int.Parse(args[2])));
            }
        }

        /// <summary>
        /// This method decorates a string with a char a specific number of times around the string.
        /// </summary>
        /// <param name="s"> Decorated string. </param>
        /// <param name="dec"> Char that decorates. </param>
        /// <param name="it"> How many times the char is repeated. </param>
        /// <returns></returns>
        private static string Decor(string s, char dec, int it)
        {
            string decorators = new string(dec, it);
            return $"{decorators} {s} {decorators}";
        }

        /// <summary>
        /// This method is called when there are no arguments.
        /// </summary>
        /// <returns> A warning message using the decorator. </returns>
        private static string Decor()
        {
            return Decor("User did not specify args!", '=', 3)
        }
    }
}
