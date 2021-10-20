using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int c;


            for (int i = 2; i <= 6; i++)
            {
                for (int j = 2; j <= 9; j++)
                {
                    c = i * j;
                    

                    Console.Write(i);

                    Console.Write("*");

                    Console.Write(j);

                    Console.Write("=");

                    Console.Write(i * j);
                    Console.WriteLine();

                }
                Console.WriteLine();
            }

        }
    }
    }

