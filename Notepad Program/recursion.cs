using System;

namespace ConsoleApp86
{
    class Program
    {
        int N = 1;
        void COUNT()
        {
            if(N==11)
            {
                return;
            }
            Console.WriteLine(N);
            N++;
            COUNT();
        }
        static void Main()
        {
            Program p = new Program();
            p.COUNT();
        }
    }
}
