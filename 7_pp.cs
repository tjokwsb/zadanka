using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbę n:");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Pary liczb naturalnych o sumie równiej " + n + ":");

        for (int i = 1; i <= n / 2; i++)
        {
            int j = n - i;
            Console.WriteLine(i + " + " + j + " = " + n);
        }
    }
}