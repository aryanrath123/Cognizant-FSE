#nullable enable

using System;

class Contact
{
    public string? Name { get; set; }
    public string? PhoneNumber { get; set; }
}

class Program
{
    static void Main()
    {
        Contact? contact = new Contact();

        contact.Name = "Aryan";
        contact.PhoneNumber = "9876543210";

        string? name = contact?.Name;

        if (name != null)
        {
            Console.WriteLine("Contact Name: " + name);
        }

        contact = null;

        Console.WriteLine(contact?.Name ?? "Contact or name is null");
    }
}