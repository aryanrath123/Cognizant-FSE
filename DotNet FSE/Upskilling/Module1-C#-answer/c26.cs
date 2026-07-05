using System;
using System.Threading;

class Program
{
    static int counter = 0;
    static object lockObject = new object();

    static void Increment()
    {
        for (int i = 0; i < 1000; i++)
        {
            lock (lockObject)
            {
                counter++;
            }
        }
    }

    static void Main()
    {
        Thread t1 = new Thread(Increment);
        Thread t2 = new Thread(Increment);
        Thread t3 = new Thread(Increment);

        t1.Start();
        t2.Start();
        t3.Start();

        t1.Join();
        t2.Join();
        t3.Join();

        Console.WriteLine("Final Counter: " + counter);
    }
}