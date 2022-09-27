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
            double number1, number2;
            double tong;
            double tich;
            double hieu;
            //nhận đầu vào từ người dùng
            Console.Write("Nhap vao number 1: ");
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap vao number 2: ");
            number2 = Convert.ToDouble(Console.ReadLine());
            //tính diện tích theo công thức 
            tong = number1 + number2;
            tich = number1 * number2;
            hieu = number1 - number2;
            //hiển thị chu vi vừa được tính ra màn hình
            Console.Write($"tong: {tong}");
            Console.Write('\n');
            Console.Write($"tich: {tich}");
            Console.Write('\n');
            Console.Write($"hieu: {hieu}");
            // Console.WriteLine("\n----Chuong trinh nay duoc dang tai Freetuts.net----\n");
        }
    }
}