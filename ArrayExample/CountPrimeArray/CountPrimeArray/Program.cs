using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountPrimeArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of array: ");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            int prime=0;
            int notprime = 0;
            int i, j;
            i = 0;
            while(i<num)
            {
                Console.Write("Enter element of array: ");
                arr[i] = int.Parse(Console.ReadLine());
                int count = 0;
                 j = 1;
                while (j <= arr[i])
                {
                    if (arr[i] % j == 0)
                        count++;
                    j++;
                }
                      if  (count == 2)
                    prime++;
                else
                            notprime++;
                i++;
            }
            Console.WriteLine("count prime number is: " + prime);
            Console.WriteLine("count not prime number is: " + notprime);
            Console.ReadLine();
        }
    }
}
