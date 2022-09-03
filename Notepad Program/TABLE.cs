using System;

namespace ConsoleApp81
{
    class Test1
    {
        protected void pip()
        {
            System.Console.WriteLine("what do you do");
        }
        
       
    }
    class demo:Test1
    {
        public void web()
        {
            System.Console.WriteLine("see you soon");
        }
        static void Main()
        {
            demo d = new demo();
            d.web();
            d.pip()

        }
    }
}
