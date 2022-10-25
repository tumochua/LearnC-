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
            Console.WriteLine("Nhap vao so nguyen lon hon 5");
            int n = Convert.ToInt32(Console.ReadLine());
            int tongChan = 0;
            int tongLe = 0;
            int tongBa = 0;
            if (n > 5)
            {
                Console.WriteLine("\nDanh sach cac so chan tu 1 den {0} la:", n);
                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("\t {0} \t", i);
                        tongChan += i;
                    }
                }
                Console.WriteLine("\ntong cac so chan tu 1 den {0} la: {1}", n, tongChan);

                Console.WriteLine("\nDanh sach cac so le tu 1 den {0} la:", n);
                for (int j = 1; j <= n; j++)
                {
                    if (j % 2 != 0)
                    {
                        Console.Write("\t{0}\t", j);
                        tongLe += j;
                    }
                }
                Console.WriteLine("\ntong cac so le tu 1 den {0} la: {1}", n, tongLe);

                Console.WriteLine("\nDanh sach cac so chia het cho 3 tu 1 den {0} la:", n);
                for (int k = 1; k <= n; k++)
                {
                    if (k % 3 == 0)
                    {
                        Console.Write("\t{0}\t", k);
                        tongBa += k;
                    }
                }
                Console.WriteLine("\ntong cac so chia het cho 3 tu 1 den {0} la: {1}", n, tongBa);
            }
            else
            {
                Console.WriteLine("\nNhap vao so nguyen lon hon 5");
            }


            Console.ReadKey();
        }


    }


}
