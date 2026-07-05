using System;

public record Employee
{
    public string Name { get; init; }
    public int Age { get; init; }
}

class Program
{
    static void Main()
    {
        Employee e1 = new Employee
        {
            Name = "Aryan",
            Age = 22
        };

        Employee e2 = e1 with { Age = 25 };

        Console.WriteLine("Original Employee:");
        Console.WriteLine(e1.Name + " " + e1.Age);

        Console.WriteLine("Modified Employee:");
        Console.WriteLine(e2.Name + " " + e2.Age);
    }
}