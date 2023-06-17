using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbę wyrazów ciągu Fibonacciego do wygenerowania:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Ciąg Fibonacciego:");

        for (int i = 0; i < n; i++)
        {
            int fibonacciNumber = CalculateFibonacci(i);
            Console.Write(fibonacciNumber + " ");
        }

        Console.ReadLine();
    }

    static int CalculateFibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return CalculateFibonacci(n - 1) + CalculateFibonacci(n - 2);
        }
    }
}