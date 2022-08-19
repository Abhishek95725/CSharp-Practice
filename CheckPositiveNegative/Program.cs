using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            System.Console.Write("Enter any number: ");
            num = Convert.ToInt32(System.Console.ReadLine());
            if (num >= 0)
                System.Console.Write("{0} is positive number", num);
            else
                System.Console.Write("{0} is negative number", num);
            System.Console.ReadLine();
        }
    }
}
