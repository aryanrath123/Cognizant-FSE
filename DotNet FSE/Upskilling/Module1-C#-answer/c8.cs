using System;

class Program
{
    static void RefMethod(ref int n)
    {
        n = n + 10;
    }

    static void OutMethod(out int n)
    {
        n = 50;
    }

    static void InMethod(in int n)
    {
        Console.WriteLine("Value inside in method: " + n);
    }

    static void Main()
    {
        int a = 10;
        Console.WriteLine("Before ref: " + a);
        RefMethod(ref a);
        Console.WriteLine("After ref: " + a);

        int b;
        Console.WriteLine("\nBefore out: Value not assigned");
        OutMethod(out b);
        Console.WriteLine("After out: " + b);

        int c = 30;
        Console.WriteLine("\nBefore in: " + c);
        InMethod(in c);
        Console.WriteLine("After in: " + c);
    }
}