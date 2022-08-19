using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountPositive
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int num = 0, positive = 0;
            while(x<5)
            {
                System.Console.Write("Enter any number: ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num >= 0)
                    positive ++;
                x = x + 1;
            }
            System.Console.WriteLine("Total Positive Number is: "+positive);
            System.Console.ReadLine();
        }      
    }
}
// Count Positive Number 