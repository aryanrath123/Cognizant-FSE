using System;
using System.Threading.Tasks;

class Program
{
    static async Task<string> UploadFile()
    {
        await Task.Delay(3000);
        return "File uploaded successfully";
    }

    static async Task Main()
    {
        try
        {
            Console.WriteLine("Uploading file...");

            string message = await UploadFile();

            Console.WriteLine(message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}