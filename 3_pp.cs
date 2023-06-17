using System;

class Program
{
    static void Main()
    {
        // Wczytaj dane od użytkownika
        Console.WriteLine("Podaj kwotę początkową:");
        double kwotaPoczatkowa = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj oprocentowanie w skali roku:");
        double oprocentowanie = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj liczbę miesięcy oszczędzania:");
        int liczbaMiesiecy = Convert.ToInt32(Console.ReadLine());

        // Oblicz kwotę zarobioną (z uwzględnieniem podatku Belki)
        double oprocentowanieMiesieczne = oprocentowanie / 12 / 100;
        double kwotaZarobiona = kwotaPoczatkowa * Math.Pow(1 + oprocentowanieMiesieczne, liczbaMiesiecy) * (1 - 0.19);

        // Wyświetl wynik
        Console.WriteLine("Kwota zarobiona (po uwzględnieniu podatku Belki): " + kwotaZarobiona);
    }
}
