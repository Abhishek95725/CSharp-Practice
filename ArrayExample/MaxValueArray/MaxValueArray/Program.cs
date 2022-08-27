using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxValueArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of Array: ");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            int max = 0;
            int i = 0;
            while(i<num)
            {
                Console.Write("Enter the number: ");
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] > max)
                    max = arr[i];
                i++;
            }
            Console.WriteLine("Max value is: "+max);
            Console.ReadLine();
        }
    }
}
