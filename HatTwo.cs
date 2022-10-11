using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnC
{
    class HatTwo
    {
        static void Main(string[] args)
        {
            double result;
            for (int i = 1; i <= 10; i++)
            {
                result = Math.Pow(i, 2);
                Console.Write(i);
                Console.Write("  ");

                Console.Write(result);
                Console.Write("\n\n");

            }
        }

    }
}