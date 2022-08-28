using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfArray_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of array: ");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            int i = 0;
            int sum = 0;
            while (i < num)
            {
                Console.Write("Enter the element of array: ");
                arr[i] = int.Parse(Console.ReadLine());
                sum = sum + arr[i];
                i++;
            }
            Console.WriteLine("Sum of array: "+sum);
            Console.ReadLine();
        }
    }
}
