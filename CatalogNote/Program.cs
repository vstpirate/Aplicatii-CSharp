using System;

class Program
{
    static void Main()
    {
        int[] note = { 8, 9, 10, 7, 6, 9 };
        int suma = 0;

        foreach (int nota in note)
            suma += nota;

        double media = (double)suma / note.Length;

        Console.WriteLine("Note: " + string.Join(", ", note));
        Console.WriteLine($"Numar note: {note.Length}");
        Console.WriteLine($"Media: {media:F2}");
        Console.WriteLine(media >= 5 ? "Promovat" : "Nepromovat");
    }
}