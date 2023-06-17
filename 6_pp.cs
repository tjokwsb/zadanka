using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbę x:");
        int x = Convert.ToInt32(Console.ReadLine());

        int n = 1;
        int factorial = 1;

        while (factorial < x)
        {
            n++;
            factorial *= n;
        }

        if (factorial == x)
        {
            Console.WriteLine($"Liczba {x} jest silnią liczby {n}.");
        }
        else
        {
            Console.WriteLine($"Liczba {x} nie jest silnią żadnej liczby.");
        }
    }
}