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
            try
            {
                //nhap so phan tu bat ky tu ban phim va in mang
                Console.Write("Nhap so phan tu cua mang: ");
                int data = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[data];
                int index;
                int sum = 0;
                for (index = 0; index < data; index++)
                {
                    Console.Write("Phan tu - {0} : ", index);
                    arr[index] = Convert.ToInt32(Console.ReadLine());
                }

                Console.Write("\nIn cac phan tu mang: ");
                for (index = 0; index < data; index++)
                {
                    Console.Write("{0}  ", arr[index]);
                }
                for (index = 0; index < data; index++)
                {
                    if (arr[index] % 3 == 0)
                    {
                        sum = sum + arr[index];
                    }
                }
                Console.Write("\nTong cac so chia het cho 3 la: " + sum);
            }
            catch
            {
                Console.Write("Nhap sai! Vui long nhap lai.");
            }
        }


    }


}
