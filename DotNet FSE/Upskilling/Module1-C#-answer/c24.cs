using System;
using System.IO;
using System.Text.Json;

class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
}

class Program
{
    static void Main()
    {
        User user = new User
        {
            Name = "Aryan",
            Age = 22,
            Email = "aryan@gmail.com"
        };

        string json = JsonSerializer.Serialize(user);

        File.WriteAllText("user.json", json);

        string data = File.ReadAllText("user.json");

        User newUser = JsonSerializer.Deserialize<User>(data);

        Console.WriteLine("Name: " + newUser.Name);
        Console.WriteLine("Age: " + newUser.Age);
        Console.WriteLine("Email: " + newUser.Email);
    }
}