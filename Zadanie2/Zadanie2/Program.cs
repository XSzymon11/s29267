// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Hejjj!");

public class Exercise1 {
    public static void Main() {
        //deklaracja tablicy
        int[] liczby = { 1, 2, 3, 4, 5 };

        //wywołanie metody do oblcizenia średniej i wyświetlanie wyniku
        double srednia = ObliczSrednia(liczby);
        Console.WriteLine($"Średnia wynosi: {srednia}");
    }

    //zgodnie z zadaniem "statyczna metoda, która przyjmuje tablicę int'ów i zwraca wyliczoną średnią
    public static double ObliczSrednia(int[] tablica) {
        if (tablica == null || tablica.Length == 0) {
            throw new ArgumentException("Tablica nie może być pusta ani null.");
        }

        double suma = 0;
        for (int i = 0; i < tablica.Length; i++) {
            suma += tablica[i];
        }

        return suma / tablica.Length;
    }
}