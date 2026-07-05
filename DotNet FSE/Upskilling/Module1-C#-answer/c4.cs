using System;

class Student
{
    public string Name { get; set; } = "";
}

class Program
{
    static void Main()
    {
        var number = 10;
        var message = "Hello C#";

        Student student = new();
        student.Name = "Aryan";

        Console.WriteLine(number + " - " + number.GetType());
        Console.WriteLine(message + " - " + message.GetType());
        Console.WriteLine(student.Name + " - " + student.GetType());

        Console.WriteLine("\nType inference makes code shorter and simple.");
        Console.WriteLine("Too much use of var may reduce code readability.");
    }
}