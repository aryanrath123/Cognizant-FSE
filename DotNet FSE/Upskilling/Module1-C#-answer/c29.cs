using System;
using System.Net;

class Program
{
    static void Main()
    {
        Console.Write("Enter your input: ");
        string input = Console.ReadLine();

        string safeInput = WebUtility.HtmlEncode(input);

        Console.WriteLine("Sanitized Input: " + safeInput);
    }
}