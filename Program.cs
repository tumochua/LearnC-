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
                int n = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[n];
                int i;
                int sum = 0;
                for (i = 0; i < n; i++)
                {
                    Console.Write("Phan tu - {0} : ", i);
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.Write("\nIn cac phan tu mang: ");
                for (i = 0; i < n; i++)
                {
                    Console.Write("{0}  ", arr[i]);
                }
                for (i = 0; i < n; i++)
                {
                    if (arr[i] % 3 == 0)
                    {
                        sum = sum + arr[i];
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
