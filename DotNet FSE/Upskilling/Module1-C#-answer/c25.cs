using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        File.WriteAllText("sample.txt", "Hello from C# FileStream");

        using (FileStream file = new FileStream("sample.txt", FileMode.Open))
        {
            byte[] data = new byte[file.Length];
            file.Read(data, 0, data.Length);

            Console.WriteLine(Encoding.UTF8.GetString(data));
        }

        using (MemoryStream memory = new MemoryStream())
        {
            byte[] data = Encoding.UTF8.GetBytes("Hello MemoryStream");

            memory.Write(data, 0, data.Length);

            Console.WriteLine("Bytes written: " + memory.Length);
        }
    }
}