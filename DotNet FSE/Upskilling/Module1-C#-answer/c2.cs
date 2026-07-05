using System;

class Student
{
    public int age;
}

class Program
{
    static void ChangeValue(int n)
    {
        n = 100;
    }

    static void ChangeObject(Student s)
    {
        s.age = 25;
    }

    static void Main()
    {
        int number = 10;
        double price = 50.5;
        string name = "Aryan";
        Student student = new Student();
        student.age = 20;

        Console.WriteLine("Before method call:");
        Console.WriteLine("Number: " + number);
        Console.WriteLine("Price: " + price);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + student.age);

        ChangeValue(number);
        ChangeObject(student);

        Console.WriteLine("\nAfter method call:");
        Console.WriteLine("Number: " + number);
        Console.WriteLine("Price: " + price);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + student.age);
    }
}