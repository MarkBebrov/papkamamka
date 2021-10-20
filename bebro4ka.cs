using System;


    class Program2
    {
        static void Main11(string[] args)
        {
            int n, c, k;
            c = 1;
            k = 0;
            n = Convert.ToInt32(Console.ReadLine());
            do
            {
                k = k + 1;
                c = c * k;



            } while (k < n);
            
            Console.WriteLine(c);
        Console.ReadKey();
        }
    }

