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

            string str1;
            Console.WriteLine("nhap sau bat ky tu ban phim");
            str1 = Console.ReadLine();
            string converToupper = str1.ToUpper();
            string[] converArray = str1.Split();
            Console.WriteLine(converToupper);
            Console.WriteLine("xau muon ghep");
            string inputString;
            inputString = Console.ReadLine();
            Console.WriteLine(string.Join(inputString, converArray));
            string[] display = str1.Split(" ");
            foreach (string str in display)
            {
                Console.WriteLine(str.ToUpper());
            }
            Console.ReadLine();
        }
    }
}



