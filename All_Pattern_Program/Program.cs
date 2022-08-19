using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Pattern_Program
{
    class Program
    {
        static void Main()
        {
            // star pettern
            //int i = 1;
            //int j;
            //while(i<=5)
            //{
            //    j = i;
            //    while(j<=5)
            //    {

            //        Console.Write(" *");
            //        j++;
            //    }
            //    i++;
            //    Console.WriteLine();
            //}
            // ===============================

            // alphabet pettern

            //int i = 1;
            //int j;
            //char c = 'A';
            //while (i <= 5)
            //{
            //    j = i;
            //    while (j <= 5)
            //    {

            //        Console.Write(" "+c);
            //        j++;
            //    }
            //    c++;
            //    i++;
            //    Console.WriteLine();
            //}
            //===============================

            //int i = 1;
            //int j;

            // char c = 'A';
            //while (i <= 5)
            //{
            //    j = i;
            //    while (j <= 5)
            //    {

            //        Console.Write(" "+c);
            //        j++;
            //        c++;
            //    }
            //    i++;
            //    Console.WriteLine();
            //}
            //================================
            // AAAAA
            // AAAA
            // AAA
            // AA
            // A
            //int ptr = 1;
            //while (ptr<=5)
            //{
            //    int ctr = ptr;
            //    while (ctr<=5)
            //    {
            //        Console.Write("A");
            //        ctr++;
            //    }
            //    ptr++;
            //    Console.WriteLine();
            //}
            //Console.WriteLine("=========================");
            //// AAAAA
            //// AAAA
            //// AAA
            //// AA
            //// A
            //for (int i = 1; i <=5 ; i++)
            //{
            //    for (int j = 5; j >=i ; j--)
            //    {
            //        Console.Write("A");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("================");
            ////1
            ////12
            ////123
            ////1234
            ////12345
            //for (int i = 1; i <=5 ; i++)
            //{
            //    for (int j = 1; j<=i ; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("===================================");
            ////12345
            ////2345
            ////345
            ////45
            ////5
            //for (int i = 1; i <=5 ; i++)
            //{
            //    for (int j = i; j <=5 ; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}
            ////11111
            ////2222
            ////333
            ////44
            ////5
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = i; j <= 5; j++)
            //    {
            //        Console.Write(i);
            //    }
            //    Console.WriteLine();
            //}
            ////11111
            ////22222
            ////33333
            ////44444
            ////55555
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        Console.Write(i);
            //    }
            //    Console.WriteLine();
            //}
            ////1
            ////23
            ////456
            ////78910
            //int x = 0;
            //for (int i = 1; i <=4 ; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        x++;
            //        Console.Write(x);
            //    }
            //    Console.WriteLine();
            //}

            int i = 1;
            while (i <= 5)
            {
                int j = 1;
                while (j <= i)
                {
                    Console.Write(" A");
                    j++;
                }
                i++;
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
