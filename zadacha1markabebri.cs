using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, c;
            c = 0;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                c = c + i;

            }
            Console.WriteLine(c);
        }
    }
}
