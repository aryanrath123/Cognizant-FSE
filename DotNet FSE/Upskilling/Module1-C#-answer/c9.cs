using System;

class Program
{
    static void CalculateFactorial(int n)
    {
        int Factorial(int num)
        {
            int result = 1;

            for (int i = 1; i <= num; i++)
                result *= i;

            return result;
        }

        Console.WriteLine("Factorial: " + Factorial(n));
    }

    static void Main()
    {
        CalculateFactorial(5);
    }
}