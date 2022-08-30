using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j;
            while (i < 5)
            {
                j = 1;
                while (j < 6)
                {
                    Console.Write("A" + " ");
                    j = j + 1;
                }
                Console.WriteLine();
                i = i + 1;
            }
            Console.ReadLine();
        }
    }
}
