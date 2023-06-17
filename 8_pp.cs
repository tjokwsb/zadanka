using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Pomyśl liczbę z przedziału 1-20.");
        Console.WriteLine("Jeśli propozycja jest za mała, odpowiedz dodatnią liczbą.");
        Console.WriteLine("Jeśli propozycja jest za duża, odpowiedz ujemną liczbą.");
        Console.WriteLine("Jeśli odgadłem liczbę, odpowiedz zerem.\n");

        int min = 1;
        int max = 20;
        int guess;
        int numberOfGuesses = 0;

        while (true)
        {
            guess = (min + max) / 2;
            numberOfGuesses++;

            Console.WriteLine($"Czy pomyślana liczba to {guess}?");
            int response = Convert.ToInt32(Console.ReadLine());

            if (response == 0)
            {
                Console.WriteLine($"Odgadłem liczbę {guess}!");
                Console.WriteLine($"Liczba pytań: {numberOfGuesses}");
                break;
            }
            else if (response < 0)
            {
                Console.WriteLine("Podalem za duża liczba.");
                max = guess - 1;
            }
            else if (response > 0)
            {
                Console.WriteLine("Podalem za mała liczba.");
                min = guess + 1;
            }

            if (min > max)
            {
                Console.WriteLine("Nie oszukuj! Nie ma takiej liczby.");
                break;
            }
        }
    }
}
