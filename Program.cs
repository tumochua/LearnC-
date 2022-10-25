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
        // nhập số nguyên dương bất kỳ từ bàn phím 1-10 va thông bao ra ten so do
        // nhập ngày tháng năm
        {
            int number;
            Console.WriteLine("Nhap vao ngay thang");
            number = Convert.ToInt16(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("thang 1");
                    break;
                case 2:
                    Console.WriteLine("Thang 2");
                    break;
                case 3:
                    Console.WriteLine("thang 3");
                    break;
                case 4:
                    Console.WriteLine("thang 4");
                    break;
                case 5:
                    Console.WriteLine("thang 5");
                    break;
                case 6:
                    Console.WriteLine("thang 6");
                    break;
                case 7:
                    Console.WriteLine("thang 7");
                    break;
                case 8:
                    Console.WriteLine("thang 8");
                    break;
                case 9:
                    Console.WriteLine("thang 9");
                    break;
                case 10:
                    Console.WriteLine("thang 10");
                    break;
                default:
                    Console.WriteLine("so  ban nhap ko nam trong khoang tu 1 - 10");
                    break;
            }
        }

    }


}
