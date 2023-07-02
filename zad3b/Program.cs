using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj rozmiar tablicy (ilość wierszy i kolumn): ");
        int rozmiar;

        while (!int.TryParse(Console.ReadLine(), out rozmiar) || rozmiar <= 0)
        {
            Console.WriteLine("Niepoprawna wartość. Podaj poprawny rozmiar tablicy (liczba dodatnia): ");
        }

        int[,] tablica = new int[rozmiar, rozmiar];
        int liczba = 1;
        int wierszGorny = 0;
        int wierszDolny = rozmiar - 1;
        int kolumnaLewa = 0;
        int kolumnaPrawa = rozmiar - 1;

        while (liczba <= rozmiar * rozmiar)
        {
            for (int i = kolumnaLewa; i <= kolumnaPrawa; i++)
            {
                tablica[wierszGorny, i] = liczba;
                liczba++;
            }
            wierszGorny++;

            for (int i = wierszGorny; i <= wierszDolny; i++)
            {
                tablica[i, kolumnaPrawa] = liczba;
                liczba++;
            }
            kolumnaPrawa--;

            for (int i = kolumnaPrawa; i >= kolumnaLewa; i--)
            {
                tablica[wierszDolny, i] = liczba;
                liczba++;
            }
            wierszDolny--;

            for (int i = wierszDolny; i >= wierszGorny; i--)
            {
                tablica[i, kolumnaLewa] = liczba;
                liczba++;
            }
            kolumnaLewa++;
        }

        for (int i = 0; i < rozmiar; i++)
        {
            for (int j = 0; j < rozmiar; j++)
            {
                Console.Write(tablica[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
