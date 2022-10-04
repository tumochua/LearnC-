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
            double number;
            // Console.WriteLine in ra màn hình
            Console.WriteLine("enter to number");
            // Console.ReadLine() nhập vào từ bàn phím
            number = Convert.ToDouble(Console.ReadLine());
            if (number >= 0)
            {
                Console.WriteLine("so you can join a group");
            }
            else
            {
                Console.WriteLine("so you're welcome");

            }

        }
    }
}