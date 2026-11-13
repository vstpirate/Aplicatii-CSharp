using System;
using System.Collections.Generic;

class Produs
{
    public string Nume { get; set; } = "";
    public decimal Pret { get; set; }
}

class Program
{
    static void Main()
    {
        var produse = new List<Produs>
        {
            new Produs { Nume = "Caiet", Pret = 15 },
            new Produs { Nume = "Pix", Pret = 8 },
            new Produs { Nume = "Radiera", Pret = 5 }
        };

        decimal total = 0;

        foreach (var produs in produse)
        {
            Console.WriteLine($"{produs.Nume}: {produs.Pret} lei");
            total += produs.Pret;
        }

        Console.WriteLine($"Total: {total} lei");
    }
}