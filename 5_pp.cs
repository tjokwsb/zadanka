using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj wartość x:");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj liczbę wyrazów n:");
        int n = Convert.ToInt32(Console.ReadLine());

        double sum = 1.0;
        double factorial = 1.0;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            double term = Math.Pow(x, i) / factorial;
            sum += term;
        }

        Console.WriteLine("Szacowana wartość funkcji e^x: " + sum);

        double realValue = Math.Exp(x);
        Console.WriteLine("Wartość rzeczywista funkcji e^x: " + realValue);
    }
}