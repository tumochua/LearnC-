using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnC
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("number[" + i + "] = ");
                number[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write(number[i] + "    ");
            }
            Console.ReadKey();
        }


    }


}
