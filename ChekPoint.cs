using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnC
{
    class ChekPoint
    {
        static void Main(string[] args)
        {
            double point;
            // Console.WriteLine in ra màn hình
            Console.WriteLine("nhap vao diem");
            // Console.ReadLine() nhập vào từ b0àn phím
            point = Convert.ToDouble(Console.ReadLine());
            if (point > 10 || point < 0)
            {
                Console.WriteLine("diem ban nhap khong chinh xac");
            }
            else
            {
                if (point < 5)
                {
                    Console.WriteLine("sinh vien yeu");
                    // Console.Write($"Diem: {point} la ");
                }
                if (point >= 5 && point <= 7)
                {
                    Console.WriteLine("sinh vien kha");
                }
                if (point >= 8 && point <= 10)
                {
                    Console.WriteLine("sinh vien tot");
                }
            }

        }
    }
}