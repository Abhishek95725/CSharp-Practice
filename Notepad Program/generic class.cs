using System;
using System.Collections.Generic;
public class Test
{
    static void Main()
    {
        var names = new HashSet<string>();
        names.Add("payal");
        names.Add("mona");
        names.Add("nishu");
        names.Add("omuu");
        names.Add("slow");
        foreach(var name in names)
        {
            Console.WriteLine(names);
        }
    }
}