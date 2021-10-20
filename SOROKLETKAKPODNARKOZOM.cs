using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int m;

            m = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write('*');

                }
                Console.WriteLine();
            }

        }
    }
}
