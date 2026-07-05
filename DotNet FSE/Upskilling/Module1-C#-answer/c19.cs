using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> names = new List<string>();

        names.Add("Aryan");
        names.Add("Rahul");
        names.Add("Amit");

        names.Remove("Rahul");

        Console.WriteLine("List:");

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        Dictionary<int, string> students = new Dictionary<int, string>();

        students.Add(1, "Aryan");
        students.Add(2, "Rahul");
        students.Add(3, "Amit");

        students.Remove(2);

        Console.WriteLine("\nDictionary:");

        foreach (var student in students)
        {
            Console.WriteLine(student.Key + " " + student.Value);
        }
    }
}