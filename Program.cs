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
            // bool isPrime = true;
            // int i, j;
            // Console.WriteLine("so nguyen la : ");
            // for (i = 2; i <= 100; i++)
            // {
            //     for (j = 2; j <= 100; j++)
            //     {
            //         if (i != j && i % j == 0)
            //         {
            //             isPrime = false;
            //             break;
            //         }
            //     }
            //     if (isPrime)
            //     {
            //         Console.Write("\t" + i);
            //     }
            //     isPrime = true;
            // }
            // Console.ReadKey();

            // lấy số dòng từ bàn phím
            Console.Write("Nhap vao so dong cua tam giac:");
            int rows = Convert.ToInt32(Console.ReadLine());
            //sử dụng vòng for thứ nhất để lặp qua các dòng
            for (int i = 1; i <= rows; i++)
            {
                //sử dụng vòng for thứ hai để in ra các khoảng trắng
                for (int j = i; j < rows; j++)
                {
                    Console.Write(" ");
                }
                //sử dụng vòng for thứ hai để in ra các ký tự *
                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    Console.Write("*");
                }
                //xuống dòng
                Console.Write("\n");
            }
            Console.WriteLine("\n----Chuong trinh nay duoc dang tai Freetuts.net----\n");
            Console.ReadLine();
        }

    }


}
