using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine("================ Do Loop ===================");
            /*  int []arr = {101,102,103,104,105};
              int i = 0;
              do
              {
                  Console.WriteLine(arr[i]);
                  i = i + 1;
              } while (i < 5);
              Console.ReadLine(); */
            //    Console.WriteLine("================ While Loop ===================");
            /*
             int i = 0;
             int []arr;
             arr = new int[5];
             arr[0] = 8;
             arr[1] = 12;
             arr[2] = 18;
             arr[3] = 25;
             arr[4] = 29;
             while(i<5)
             {
                 Console.WriteLine(arr[i]);
                 i = i + 1;
             }
             Console.ReadLine(); 
             */
            //  Console.WriteLine("=============== For Loop ====================");
            /*
              int[] arr = { 108, 102, 109, 124, 148 };
              for(int i=0; i<5; i++)
              {
                  Console.WriteLine(arr[i]);
              }
              Console.ReadLine();
              */
            Console.WriteLine("================ foreach Loop ===================");
            int i = 0;
            int[] arr = { 108, 102, 109, 124, 148 };
            foreach(int a in arr)
            {
                Console.WriteLine(arr[i]);
                i = i + 1;
            }
            Console.ReadLine();
        }
    }
}
