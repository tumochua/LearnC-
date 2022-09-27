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
            //khai báo bán kính và dien tích hình tròn
            double S, r;
            //nhận đầu vào từ người dùng
            Console.Write("Nhap vao ban kinh r: ");
            r = Convert.ToDouble(Console.ReadLine());
            //tính diện tích theo công thức 
            S = Math.PI * r * r;
            //hiển thị chu vi vừa được tính ra màn hình
            Console.Write($"Dien tich hinh tron la: {S}");
            Console.WriteLine("\n----Chuong trinh nay duoc dang tai Freetuts.net----\n");
        }
    }
}