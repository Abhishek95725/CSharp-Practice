using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumberANDCountEvenOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int even = 0, odd = 0;
            Console.Write("Enter size of array: ");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            int k = 0;
            while (k < num)
            {
                Console.Write("Enter number: ");
                arr[k] = int.Parse(Console.ReadLine());
                k++;
            }
            int i = num-1;
            while (i >= 0)
            {
                Console.WriteLine(arr[i]);
                int j = 0;
                while (j < 1)
                {
                    if (arr[i] % 2 == 0)
                        even++;
                    else
                        odd++;
                    j++;
                }
                i--;
            }
                Console.WriteLine("Even Number: "+even);
                Console.WriteLine("Odd Number: " +odd);
                Console.ReadLine();
            }
        }
    }

