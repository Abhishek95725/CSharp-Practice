using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckHighestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, high = 0, num = 0;
            while (x < 5)
            {
                System.Console.Write("Enter any number: ");
                num = Convert.ToInt32(System.Console.ReadLine());
                if (num > high)
                    high = num;
                x = x + 1;
            }
                    System.Console.WriteLine("High number is: "+high);
            System.Console.ReadLine();
            }
        }
    }
