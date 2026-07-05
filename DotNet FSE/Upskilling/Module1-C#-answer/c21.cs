using System;

class Program
{
    static void CheckObject(object obj)
    {
        if (obj is int n)
            Console.WriteLine("Integer: " + n);
        else if (obj is string s)
            Console.WriteLine("String: " + s);

        string result = obj switch
        {
            int x => "Square: " + (x * x),
            string x => "Length: " + x.Length,
            double x => "Double value: " + x,
            _ => "Unknown type"
        };

        Console.WriteLine(result);
    }

    static void Main()
    {
        CheckObject(10);
        CheckObject("Aryan");
        CheckObject(20.5);
    }
}