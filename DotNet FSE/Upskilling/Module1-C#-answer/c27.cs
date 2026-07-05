using System;
using System.Threading;

class Program
{
    static object lock1 = new object();
    static object lock2 = new object();

    static void Task1()
    {
        lock (lock1)
        {
            Thread.Sleep(100);

            if (Monitor.TryEnter(lock2, 1000))
            {
                try
                {
                    Console.WriteLine("Thread 1 completed");
                }
                finally
                {
                    Monitor.Exit(lock2);
                }
            }
            else
            {
                Console.WriteLine("Thread 1 avoided deadlock");
            }
        }
    }

    static void Task2()
    {
        lock (lock2)
        {
            Thread.Sleep(100);

            if (Monitor.TryEnter(lock1, 1000))
            {
                try
                {
                    Console.WriteLine("Thread 2 completed");
                }
                finally
                {
                    Monitor.Exit(lock1);
                }
            }
            else
            {
                Console.WriteLine("Thread 2 avoided deadlock");
            }
        }
    }

    static void Main()
    {
        Thread t1 = new Thread(Task1);
        Thread t2 = new Thread(Task2);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();
    }
}