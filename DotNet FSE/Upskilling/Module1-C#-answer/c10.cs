using System;

class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Car()
    {
        Make = "Toyota";
        Model = "Camry";
        Year = 2020;
    }

    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public void Display()
    {
        Console.WriteLine(Make + " " + Model + " " + Year);
    }
}

class Program
{
    static void Main()
    {
        Car car1 = new Car();
        Car car2 = new Car("Honda", "City", 2024);

        car1.Display();
        car2.Display();
    }
}