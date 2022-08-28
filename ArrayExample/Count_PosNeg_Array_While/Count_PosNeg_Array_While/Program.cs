using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_PosNeg_Array_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of array: ");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            int i = 0;
            int positive=0;
            int negative=0;
            while (i < num)
            {
                Console.Write("Enter the element of array: ");
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] > 0)
                    positive++;
                else
                    negative++;
                i++;
            }
            Console.WriteLine("Count positive number: " + positive);
            Console.WriteLine("Count negative number: " + negative);
            Console.ReadLine();
        }
    }
}
