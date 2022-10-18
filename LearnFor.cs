using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnC
{
    class LearnFor
    {
        static void Main(string[] args)
        {
            // check so chan le
            // for (int number = 1; number <= 100; number++)
            // {
            //     if (number % 2 != 0)
            //     {
            //         Console.Write("\t {0}", number);
            //     }
            //     if (number % 10 == 0)
            //     {
            //         Console.WriteLine("\n");

            //     }
            // }
            // Console.ReadKey();

            // tam giac giảm

            int val = 5;
            int i, j, k;
            for (i = 1; i <= val; i++)
            {
                for (j = 1; j <= val - i; j++)
                {
                    // Console.Write(" ");  
                }
                for (k = 1; k <= j; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();

            // tam giac tăng
            // int val = 5;
            // int i, j, k;
            // for (i = 1; i <= val; i++)
            // {
            //     for (j = 1; j <= val - i; j++)
            //     {
            //         // Console.Write("");  
            //     }
            //     for (k = 1; k <= i; k++)
            //     {
            //         Console.Write("*");
            //     }
            //     Console.WriteLine("");
            // }
            // Console.ReadLine();


        }

    }
}