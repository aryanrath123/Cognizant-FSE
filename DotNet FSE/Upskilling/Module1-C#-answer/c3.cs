using System;

class Person(string name, int age)
{
    public string Name { get; set; } = name;
    public int Age { get; set; } = age;

    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person("Aryan", 22);

        Console.WriteLine("Person Details:");
        Console.WriteLine("Name: " + person.Name);
        Console.WriteLine("Age: " + person.Age);

        Console.WriteLine("\nFull Information:");
        person.DisplayInfo();
    }
}