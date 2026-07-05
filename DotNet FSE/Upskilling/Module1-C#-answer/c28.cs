using System;
using System.Diagnostics;

class Logger
{
    public static void Log(string message)
    {
        Trace.WriteLine(message);
        Console.WriteLine(message);
    }
}

class Program
{
    static void Main()
    {
        TextWriterTraceListener file =
            new TextWriterTraceListener("log.txt");

        Trace.Listeners.Add(file);
        Trace.AutoFlush = true;

        Logger.Log("Application started");
        Logger.Log("Logging message");
        Logger.Log("Application ended");

        Trace.Close();
    }
}