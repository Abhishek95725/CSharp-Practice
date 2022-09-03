using System;

namespace ConsoleApp81
{
    class Test1
    {
        public virtual void pip()
        {
            System.Console.WriteLine("what do you do");
        }


    }
    class demo : Test1
    {
        public  override void pip()
        {
            System.Console.WriteLine("see you soon");
        }
        static void Main()
        {
           Test1 d = new demo();
            
            d.pip();

        }
    }
}
