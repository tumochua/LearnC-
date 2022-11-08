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
            Console.WriteLine("\n nhap number tu ban phim");
            Console.WriteLine("so thu nhat");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("so thu hai");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sum {0}", handleSum(number1, number2));
            Console.ReadKey();
        }
        static int handleSum(int number1, int number2)
        {
            return number1 + number2;

        }


    }


}
