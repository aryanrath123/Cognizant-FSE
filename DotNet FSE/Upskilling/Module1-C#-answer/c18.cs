using System;

class Student
{
    public required string Name { get; set; }
    public required int Age { get; set; }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student
        {
            Name = "Aryan",
            Age = 22
        };

        Console.WriteLine("Name: " + s1.Name);
        Console.WriteLine("Age: " + s1.Age);
    }
}