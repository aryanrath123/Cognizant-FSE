using System;

class Parent
{
    public int publicValue = 10;
    private int privateValue = 20;
    protected int protectedValue = 30;

    public void ShowPrivate()
    {
        Console.WriteLine("Private: " + privateValue);
    }
}

class Child : Parent
{
    public void Display()
    {
        Console.WriteLine("Public: " + publicValue);
        Console.WriteLine("Protected: " + protectedValue);
    }
}

class Program
{
    static void Main()
    {
        Child child = new Child();
        child.Display();
        child.ShowPrivate();

        Parent parent = new Parent();
        Console.WriteLine("Public: " + parent.publicValue);
    }
}