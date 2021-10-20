using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, c, kakkakakakak;
            c = 0;
            kakkakakakak = 0;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= n; i = i + 2)
            {
                c = c + i;
                kakkakakakak = kakkakakakak + 1;
            }




            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
    }

