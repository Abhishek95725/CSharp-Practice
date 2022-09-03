using System;

namespace ConsoleApp83
{
    abstract class Pop
    {
        public abstract void interest();
        public void Pass()
        {
            System.Console.WriteLine("jio");
        }

    }
    class Demo : Pop
    {
        public override void interest()
        {
            System.Console.WriteLine("where r u from");

        }
        static void Main()
        {
           Demo d = new Demo();
                d.interest();
        }
    }
}
