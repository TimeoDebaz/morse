// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {



        Console.WriteLine("=== Convertisseur de texte en code Morse ===");
        Console.WriteLine("Entrez un mot ou une phrase (sans accents, lettres A-Z) :");

        string texte = Console.ReadLine();

        Console.WriteLine("Résultat en Morse : ");

        if (texte == "A")
            Console.WriteLine(".-");

        if (texte == "B")
            Console.WriteLine("-...");

        if (texte == "C")
            Console.WriteLine("-.-.");

        if (texte == "D")
            Console.WriteLine("-..");

        if (texte == "E")
            Console.WriteLine(".");

        if (texte == "F")
            Console.WriteLine("..-.");

        if (texte == "G")
            Console.WriteLine("--.");

        if (texte == "H")
            Console.WriteLine("....");

        if (texte == "I")
            Console.WriteLine("..");

        if (texte == "J")
            Console.WriteLine(".---");

        if (texte == "K")
            Console.WriteLine("-.-");

        if (texte == "L")
            Console.WriteLine(".-..");

        if (texte == "M")
            Console.WriteLine("--");

        if (texte == "N")
            Console.WriteLine("-.");

        if (texte == "O")
            Console.WriteLine("---");

        if (texte == "P")
            Console.WriteLine(".--.");

        if (texte == "Q")
            Console.WriteLine("--.-");

        if (texte == "R")
            Console.WriteLine(".-.");

        if (texte == "S")
            Console.WriteLine("...");

        if (texte == "T")
            Console.WriteLine("-");

        if (texte == "U")
            Console.WriteLine("..-");

        if (texte == "V")
            Console.WriteLine("...-");

        if (texte == "W")
            Console.WriteLine(".--");

        if (texte == "X")
            Console.WriteLine("-..-");

        if (texte == "Y")
            Console.WriteLine("-.--");

        if (texte == "Z")
            Console.WriteLine("--..");
    }
}

