using System;

class Program
{
    static void Main()
    {
        bool ruleaza = true;

        while (ruleaza)
        {
            Console.WriteLine();
            Console.WriteLine("APLICATIE GESTIUNE");
            Console.WriteLine("1. Clienti");
            Console.WriteLine("2. Programari");
            Console.WriteLine("3. Rapoarte");
            Console.WriteLine("4. Iesire");
            Console.Write("Alegeti optiunea: ");
            string? optiune = Console.ReadLine();

            switch (optiune)
            {
                case "1": Console.WriteLine("Modul Clienti"); break;
                case "2": Console.WriteLine("Modul Programari"); break;
                case "3": Console.WriteLine("Modul Rapoarte"); break;
                case "4":
                    Console.WriteLine("La revedere!");
                    ruleaza = false;
                    break;
                default: Console.WriteLine("Optiune invalida"); break;
            }
        }
    }
}