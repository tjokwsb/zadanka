using System;

class Program
{
    static int Potegowanie(int podstawa, int wykladnik)
    {
        int wynik = 1;

        while (wykladnik > 0)
        {
            wynik *= podstawa;
            wykladnik--;
        }

        return wynik;
    }

    static void Main(string[] args)
    {
        Console.Write("Podaj podstawę potęgi: ");
        int podstawa = Convert.ToInt32(Console.ReadLine());

        Console.Write("Podaj wykładnik potęgi: ");
        int wykladnik = Convert.ToInt32(Console.ReadLine());

        int wynik = Potegowanie(podstawa, wykladnik);
        Console.WriteLine($"Wynik potęgowania {podstawa} do potęgi {wykladnik} wynosi: {wynik}");
    }
}
