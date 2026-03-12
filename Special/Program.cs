using System;

namespace Special
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insert n-th number of the special sequence: ");
            int numb = int.Parse(Console.ReadLine());
            Console.WriteLine(GetSpecial(numb));
        }
        private static int GetSpecial(int n)
        {
            int spnumb;
            if (n == 0)
            {
                spnumb = 0;
            }
            else if (n == 1)
            {
                spnumb = 1;
            }
            else
            {
                spnumb = GetSpecial(n - 1) + 2 * GetSpecial(n - 2);
            }
            return spnumb;
        }
    }
}
