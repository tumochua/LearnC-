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
            Console.Write("Nhap so luong toi da * hang:");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input < 2)
            {
                CheckNumber();
            }
            else
            {
                //for loop to work until i = n 

                Dispaly1(input);
                Console.Write("\n");
                Dispaly2(input);
                Console.Write("\n");
                Dispaly3(input);
                Console.Write("\n");
                Display4(9);
                Console.Write("\n");
                Display5(9);
                Dispaly6(input);
            }


            static void CheckNumber()
            {
                Console.WriteLine("So ban nhap phai lon hon 2");
            }
            static void DisplayFigure(string figure)
            {
                Console.WriteLine(figure);
            }

            static void Dispaly1(int input)
            {
                DisplayFigure("hinh so 1");
                for (int index = 1; index <= input; index++)
                {
                    for (int k = 1; k < index + 1; k++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
                Console.Write("\n");
            }
            static void Dispaly2(int input)
            {
                DisplayFigure("hinh so 2");
                for (int row = input; row >= 1; row--)
                {
                    for (int col = 1; col <= row; col++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
                Console.Write("\n");
            }
            static void Dispaly3(int input)
            {
                DisplayFigure("hinh so 3");
                for (int index = 1; index <= input; index++)
                {
                    for (int j = 1; j <= input; j++)
                    {
                        if (j <= 5 - index)
                        {
                            Console.Write("   ");
                        }
                        else
                        {
                            Console.Write(" * ");
                        }

                    }
                    Console.Write("\n");
                }
                Console.WriteLine("\n\n");
            }
            static void Display4(int input)
            {
                DisplayFigure("hinh so 4");

                for (int i = 1; i <= input; i++)
                {
                    //for loop to add space
                    for (int j = 1; j <= (input - i); j++)
                    {
                        Console.Write("   ");
                    }
                    for (int k = 1; k < i * 2; k++)
                    {
                        Console.Write(" * ");
                    }
                    Console.WriteLine();
                }

                for (int i = input - 1; i >= 1; i--)
                {
                    for (int j = 1; j <= (input - i); j++)
                    {
                        Console.Write("   ");
                    }
                    for (int k = 1; k < i * 2; k++)
                    {
                        Console.Write(" * ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
            }
            static void Display5(int input)
            {
                DisplayFigure("hinh so 5");
                for (int i = 1; i <= input; i++)
                {
                    //for loop to add space
                    for (int j = 1; j <= (input - i); j++)
                    {
                        Console.Write("   ");
                    }
                    for (int k = 1; k < i * 2; k++)
                    {
                        Console.Write(" * ");
                    }
                    Console.WriteLine();
                }
            }
            static void Dispaly6(int input)
            {
                DisplayFigure("hinh so 6");
                for (int index = 1; index <= input; index++)
                {
                    for (int j = 1; j <= input; j++)
                    {
                        if (j >= index)
                        {
                            Console.Write(" * ");
                        }
                        else
                        {
                            Console.Write("   ");
                        }

                    }
                    Console.Write("\n");
                }
            }


        }


        // static void Main(string[] args)
        // {
        //     Console.WriteLine("Nhap vao n: ");
        //     int n = Convert.ToInt32(Console.ReadLine());
        //     for (int i = 1; i <= n; i++)
        //     {
        //         for (int j = 1; j <= n; j++)
        //         {
        //             if (j <= i)
        //             {
        //                 Console.Write(" * ");
        //             }
        //             else
        //             {
        //                 Console.Write("   ");
        //             }

        //         }
        //         Console.Write("\n");
        //     }
        //     Console.WriteLine("\n\n");

        //     for (int i = 1; i <= n; i++)
        //     {
        //         for (int j = 1; j <= n; j++)
        //         {
        //             if (j <= 5 + 1 - i)
        //             {
        //                 Console.Write(" * ");
        //             }
        //             else
        //             {
        //                 Console.Write("   ");
        //             }

        //         }
        //         Console.Write("\n");
        //     }
        //     Console.WriteLine("\n\n");

        //     for (int i = 1; i <= n; i++)
        //     {
        //         for (int j = 1; j <= n; j++)
        //         {
        //             if (j >= i)
        //             {
        //                 Console.Write(" * ");
        //             }
        //             else
        //             {
        //                 Console.Write("   ");
        //             }

        //         }
        //         Console.Write("\n");
        //     }
        //     Console.WriteLine("\n\n");

        //     for (int i = 1; i <= n; i++)
        //     {
        //         for (int j = 1; j <= n; j++)
        //         {
        //             if (j <= 5 - i)
        //             {
        //                 Console.Write("   ");
        //             }
        //             else
        //             {
        //                 Console.Write(" * ");
        //             }

        //         }
        //         Console.Write("\n");
        //     }
        //     Console.WriteLine("\n\n");

        //     for (int i = 1; i <= n; i++)
        //     {
        //         for (int j = 1; j < 2 * n; j++)
        //         {
        //             if (Math.Abs(n - j) < i)
        //             {
        //                 Console.Write(" * ");
        //             }
        //             else
        //             {
        //                 Console.Write("   ");
        //             }
        //         }
        //         Console.WriteLine("\n");
        //     }
        //     for (int i = n - 1; i >= 1; i--)
        //     {
        //         for (int j = 1; j < 2 * n; j++)
        //         {
        //             if (Math.Abs(n - j) < i)
        //             {
        //                 Console.Write(" * ");
        //             }
        //             else
        //             {
        //                 Console.Write("   ");
        //             }
        //         }
        //         Console.WriteLine("\n");
        //     }
        //     Console.ReadKey();

        // }

    }
}



