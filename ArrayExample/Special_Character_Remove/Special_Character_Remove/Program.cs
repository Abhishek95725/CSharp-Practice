using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Character_Remove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "abhishek108@gmail.com";
              int str1 = str.Length-1;
            for(int i = 0; i <= str1; i++)
            {
                if(str[i] >= 97 && str[i] <= 122 || str[i] >= 48 && str[i]<=57)
                {
                    Console.Write(str[i]);
                }
            }
            Console.ReadLine();
        }
        }
    }

