#nullable enable

using System;

class Person
{
    public string? Name { get; set; }
}

class Program
{
    static void Main()
    {
        Person? person = new Person();

        Console.WriteLine(person?.Name ?? "Name is not available");

        person.Name = "Aryan";

        if (person != null)
        {
            Console.WriteLine("Name: " + person.Name);
        }

        person = null;

        Console.WriteLine(person?.Name ?? "Person is null");
    }
}