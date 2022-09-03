using System;
using System.Collections.Generic;
class Program
{
    public static void Main()
    {
        var names = new Stack<string>();
        names.Push("raw");
        names.Push("lavi");
        names.Push("pooja 1");
        names.Push("pooja");
        names.Push("pooja");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine("peek element" + names.Peek());
        Console.WriteLine("Pop" + names.Pop());
        Console.WriteLine("After Pop, Peek element: " + names.Peek());


    }
}