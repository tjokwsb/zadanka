using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj kwotę początkową: ");
        double kwotaPoczatkowa = double.Parse(Console.ReadLine());

        Console.Write("Podaj oprocentowanie konta w skali roku: ");
        double oprocentowanie = double.Parse(Console.ReadLine());

        Console.Write("Podaj liczbę miesięcy oszczędzania: ");
        int liczbaMiesiecy = int.Parse(Console.ReadLine());

        double oprocentowanieMiesieczne = oprocentowanie / 12 / 100;

        double kwotaKoncowa = kwotaPoczatkowa * Math.Pow((1 + oprocentowanieMiesieczne), liczbaMiesiecy);
        double podatekBelki = 0.19;
        double podatek = (kwotaKoncowa - kwotaPoczatkowa) * podatekBelki;
        double kwotaZysku = kwotaKoncowa - kwotaPoczatkowa - podatek;

        Console.WriteLine("Kwota końcowa: " + kwotaKoncowa.ToString("N2"));
        Console.WriteLine("Zysk: " + kwotaZysku.ToString("N2"));
    }
}