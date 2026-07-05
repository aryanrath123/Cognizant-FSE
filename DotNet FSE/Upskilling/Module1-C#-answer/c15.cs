using System;

abstract class Vehicle
{
    public abstract void Drive();
}

interface IDrivable
{
    void Start();
}

class Car : Vehicle, IDrivable
{
    public override void Drive()
    {
        Console.WriteLine("Car is driving");
    }

    public void Start()
    {
        Console.WriteLine("Car is starting");
    }
}

class Program
{
    static void Main()
    {
        Vehicle v = new Car();
        IDrivable d = new Car();

        v.Drive();
        d.Start();
    }
}