using System;

class Program
{
    static (int, string) GetDetails()
    {
        return (22, "Aryan");
    }

    static void Main()
    {
        var (age, name) = GetDetails();

        Console.WriteLine("Age: " + age);
        Console.WriteLine("Name: " + name);
    }
}