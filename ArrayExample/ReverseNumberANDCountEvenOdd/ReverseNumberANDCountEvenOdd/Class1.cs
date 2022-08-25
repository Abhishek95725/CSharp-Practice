using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumberANDCountEvenOdd
{
    internal class Class1
    {
        void CountEvenOdd(int[] arr)
        {
            int even = 0;
            int odd = 0;
            Console.Write("My Array: ");
                for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }
            Console.WriteLine();
            for(int j = 0; j < arr.Length; j++)
            {
                if (arr[j]%2==0)
                {
                    Console.WriteLine("Even number is: " + arr[j]);
                    even++;
                }
                else
                {
                    Console.WriteLine("Odd number is: " + arr[j]);
                    odd++;
                }
            }
            Console.WriteLine("Total Even Number is: "+even);
            Console.WriteLine("Total Odd Number is: " +odd);
        }
        public static void Main(string[] args)
        {
            int[] ar = new int[5];
            for (int i = 0; i < ar.Length; i++)
            {
                Console.Write("Enter the value of " + (i + 1) + " Array :");
                ar[i] = int.Parse(Console.ReadLine());
            }
            Class1 obj = new Class1();
            obj.CountEvenOdd(ar);
        }
    }
}
