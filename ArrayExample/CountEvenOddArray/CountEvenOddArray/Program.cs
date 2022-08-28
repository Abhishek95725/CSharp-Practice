using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountEvenOddArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of array: ");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            int i = 0;
            int even = 0;
            int odd = 0;
            while (i < num)
            {
                Console.Write("Enter the element of array: ");
                arr[i] = int.Parse(Console.ReadLine());
                
                if (arr[i] % 2 == 0)
                    even++;
                else
                    odd++;
                i++;
            }
            Console.WriteLine("Count even number: "+even);
            Console.WriteLine("Count odd number: "+odd);
            Console.ReadLine();
        }
    }
}
