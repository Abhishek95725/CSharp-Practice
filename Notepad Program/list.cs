using System;
using System.Collections.Generic;

namespace ConsoleApp87
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new HashSet<string>();
            names.Add("payal");
            names.Add("nishu");
            names.Add("mona");
            names.Add("riya");
            names.Add("omuu");
           
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
