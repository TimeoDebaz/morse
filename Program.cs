using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Convertisseur de texte en code Morse ===");
        Console.WriteLine("Entrez un mot ou une phrase (sans accents, lettres A-Z) :");

        string texte = Console.ReadLine();
        string texteMajuscule = texte.ToUpper();

        Console.WriteLine("Résultat en Morse :");

        foreach (char lettre in texteMajuscule)
        {
            if (lettre == 'A')
                Console.Write(".- ");

            else if (lettre == 'B')
                Console.Write("-... ");

            else if (lettre == 'C')
                Console.Write("-.-. ");

            else if (lettre == 'D')
                Console.Write("-.. ");

            else if (lettre == 'E')
                Console.Write(". ");

            else if (lettre == 'F')
                Console.Write("..-. ");

            else if (lettre == 'G')
                Console.Write("--. ");

            else if (lettre == 'H')
                Console.Write(".... ");

            else if (lettre == 'I')
                Console.Write(".. ");

            else if (lettre == 'J')
                Console.Write(".--- ");

            else if (lettre == 'K')
                Console.Write("-.- ");

            else if (lettre == 'L')
                Console.Write(".-.. ");

            else if (lettre == 'M')
                Console.Write("-- ");

            else if (lettre == 'N')
                Console.Write("-. ");

            else if (lettre == 'O')
                Console.Write("--- ");

            else if (lettre == 'P')
                Console.Write(".--. ");

            else if (lettre == 'Q')
                Console.Write("--.- ");

            else if (lettre == 'R')
                Console.Write(".-. ");

            else if (lettre == 'S')
                Console.Write("... ");

            else if (lettre == 'T')
                Console.Write("- ");

            else if (lettre == 'U')
                Console.Write("..- ");

            else if (lettre == 'V')
                Console.Write("...- ");

            else if (lettre == 'W')
                Console.Write(".-- ");

            else if (lettre == 'X')
                Console.Write("-..- ");

            else if (lettre == 'Y')
                Console.Write("-.-- ");

            else if (lettre == 'Z')
                Console.Write("--.. ");

            else if (lettre == '0')
                Console.Write("----- ");

            else if (lettre == '1')
                Console.Write(".---- ");

            else if (lettre == '2')
                Console.Write("..--- ");

            else if (lettre == '3')
                Console.Write("...-- ");

            else if (lettre == '4')
                Console.Write("....- ");

            else if (lettre == '5')
                Console.Write("..... ");

            else if (lettre == '6')
                Console.Write("-.... ");

            else if (lettre == '7')
                Console.Write("--... ");

            else if (lettre == '8')
                Console.Write("---.. ");

            else if (lettre == '9')
                Console.Write("----. ");

            else if (lettre == ' ')
                Console.Write("/ ");

            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erreur : le caractère '" + lettre + "' n'est pas autorisé.");
                Console.ResetColor();
                Console.WriteLine("");
                Console.WriteLine("Fin du programme");

                return;
            }

        }
    }
}