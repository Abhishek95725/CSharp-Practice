using System;

namespace ConsoleApp80
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,i=1;
            num = System.Convert.ToInt32(System.Console.ReadLine());
            while(i<11)
            {
                System.Console.WriteLine(num + "*" + i +"=" + num * i);
                i++;

            }
        }
    }
}
