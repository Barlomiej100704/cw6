using System;

class Program
{
    static void Main()
    {
        int[,] tablica = new int[10, 10];
        int liczba = 1;
        int wierszGorny = 0;
        int wierszDolny = 9;
        int kolumnaLewa = 0;
        int kolumnaPrawa = 9;

        while (liczba <= 100)
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

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(tablica[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
