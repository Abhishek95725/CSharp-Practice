using System;
using System.Collections.Generic;
class Program
{
    public static void Main()
    {
        var names = new SortedSet<string>();
        names.Add("raw");
        names.Add("lavi");
        names.Add("pooja");
        names.Add("pooja");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}