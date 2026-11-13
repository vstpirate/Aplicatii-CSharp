using System;

class Program
{
    static void Main()
    {
        Console.Write("Lungime: ");
        double lungime = double.Parse(Console.ReadLine()!);
        Console.Write("Latime: ");
        double latime = double.Parse(Console.ReadLine()!);

        if (lungime <= 0 || latime <= 0)
        {
            Console.WriteLine("Eroare: lungimea si latimea trebuie sa fie mai mari decat 0.");
            return;
        }

        double arie = lungime * latime;
        double perimetru = 2 * (lungime + latime);

        Console.WriteLine($"Aria = {arie}");
        Console.WriteLine($"Perimetrul = {perimetru}");
    }
}