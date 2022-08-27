using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinValueArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
               Console.Write("Enter the size of array: ");
                int num = int.Parse(Console.ReadLine());
                int[] arr = new int[num];
                int min = int.MaxValue;
                int i = 0;
                while (i < num)
                {
                    Console.Write("Enter the number: ");
                    arr[i] = int.Parse(Console.ReadLine());
                    if (arr[i] < min)
                        min = arr[i];
                    i++;
                }
                Console.WriteLine("Min value: " + min);
                Console.ReadLine();
            }
        }
    }