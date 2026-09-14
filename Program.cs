using System;

#pragma warning disable CA1416 // désactive l'erreur de Console.Beep
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
            {
                Console.Write(".- ");
                Console.Beep(800, 200);
                Console.Beep(800, 400);
            }

            else if (lettre == 'B')
            {
                Console.Write("-... ");
                Console.Beep(800, 400);
                Console.Beep(800, 200);
                Console.Beep(800, 200);
                Console.Beep(800, 200);
            }

            else if (lettre == 'C')
            {
                Console.Write("-.-. ");
                Console.Beep(800, 400);
                Console.Beep(800, 200);
                Console.Beep(800, 400);
                Console.Beep(800, 200);
            }

            else if (lettre == 'D')
            {
                Console.Write("-.. ");
                Console.Beep(800, 400);
                Console.Beep(800, 200);
                Console.Beep(800, 200);
            }

            else if (lettre == 'E')
            {
                Console.Write(". ");
                Console.Beep(800, 200);
            }

            else if (lettre == 'F')
            {
                Console.Write("..-. ");
                Console.Beep(800, 200);
                Console.Beep(800, 200);
                Console.Beep(800, 400);
                Console.Beep(800, 200);
            }

            else if (lettre == 'G')
            {
                Console.Write("--. ");
                Console.Beep(800, 400);
                Console.Beep(800, 400);
                Console.Beep(800, 200);
            }

            else if (lettre == 'H')
            {
                Console.Write(".... ");
                Console.Beep(800, 200);
                Console.Beep(800, 200);
                Console.Beep(800, 200);
                Console.Beep(800, 200);
            }

            else if (lettre == 'I')
            {
                Console.Write(".. ");
                Console.Beep(800, 200);
                Console.Beep(800, 200);
            }

            else if (lettre == 'J')
            {
                Console.Write(".--- ");
                Console.Beep(800, 200);
                Console.Beep(800, 400);
                Console.Beep(800, 400);
                Console.Beep(800, 400);
            }

            else if (lettre == 'K')
            {
                Console.Write("-.- ");
                Console.Beep(800, 400);
                Console.Beep(800, 200);
                Console.Beep(800, 400);
            }

            else if (lettre == 'L')
            {
                Console.Write(".-.. ");
                Console.Beep(800, 200);
                Console.Beep(800, 400);
                Console.Beep(800, 200);
                Console.Beep(800, 200);
            }

            else if (lettre == 'M')
            {
                Console.Write("-- ");
                Console.Beep(800, 400);
                Console.Beep(800, 400);
            }

            else if (lettre == 'N')
            {
                Console.Write("-. ");
                Console.Beep(800, 400);
                Console.Beep(800, 200);
            }

            else if (lettre == 'O')
            {
                Console.Write("--- ");
                Console.Beep(800, 400);
                Console.Beep(800, 400);
                Console.Beep(800, 400);
            }

            else if (lettre == 'P')
            {
                Console.Write(".--. ");
                Console.Beep(800, 200);
                Console.Beep(800, 400);
                Console.Beep(800, 400);
                Console.Beep(800, 200);
            }

            else if (lettre == 'Q')
            {
                Console.Write("--.- ");
                Console.Beep(800, 400);
                Console.Beep(800, 400);
                Console.Beep(800, 200);
                Console.Beep(800, 400);
            }

            else if (lettre == 'R')
            {
                Console.Write(".-. ");
                Console.Beep(800, 200);
                Console.Beep(800, 400);
                Console.Beep(800, 200);
            }

            else if (lettre == 'S')
            {
                Console.Write("... ");
                Console.Beep(800, 200);
                Console.Beep(800, 200);
                Console.Beep(800, 200);
            }

            else if (lettre == 'T')
            {
                Console.Write("- ");
                Console.Beep(800, 400);
            }

            else if (lettre == 'U')
            {
                Console.Write("..- ");
                Console.Beep(800, 200);
                Console.Beep(800, 200);
                Console.Beep(800, 400);
            }

            else if (lettre == 'V')
            {
                Console.Write("...- ");
                Console.Beep(800, 200);
                Console.Beep(800, 200);
                Console.Beep(800, 200);
                Console.Beep(800, 400);
            }

            else if (lettre == 'W')
            {
                Console.Write(".-- ");
                Console.Beep(800, 200);
                Console.Beep(800, 400);
                Console.Beep(800, 400);
            }

            else if (lettre == 'X')
            {
                Console.Write("-..- ");
                Console.Beep(800, 400);
                Console.Beep(800, 200);
                Console.Beep(800, 200);
                Console.Beep(800, 400);
            }

            else if (lettre == 'Y')
            {
                Console.Write("-.-- ");
                Console.Beep(800, 400);
                Console.Beep(800, 200);
                Console.Beep(800, 400);
                Console.Beep(800, 400);
            }

            else if (lettre == 'Z')
            {
                Console.Write("--.. ");
                Console.Beep(800, 400);
                Console.Beep(800, 400);
                Console.Beep(800, 200);
                Console.Beep(800, 200);
            }

            else if (lettre == '0')
            {
                Console.Write("----- ");
                Console.Beep(800, 400);
                Console.Beep(800, 400);
                Console.Beep(800, 400);
                Console.Beep(800, 400);
                Console.Beep(800, 400);
            }

            else if (lettre == '1')
            {
                Console.Write(".---- ");
                Console.Beep(800, 200);
                Console.Beep(800, 400);
                Console.Beep(800, 400);
                Console.Beep(800, 400);
                Console.Beep(800, 400);
            }

            else if (lettre == '2')
            {
                Console.Write("..--- ");
                Console.Beep(800, 200);
                Console.Beep(800, 200);
                Console.Beep(800, 400);
                Console.Beep(800, 400);
                Console.Beep(800, 400);
            }

            else if (lettre == '3')
            {
                Console.Write("...-- ");
                Console.Beep(800, 200);
                Console.Beep(800, 200);
                Console.Beep(800, 200);
                Console.Beep(800, 400);
                Console.Beep(800, 400);
            }

            else if (lettre == '4')
            {
                Console.Write("....- ");
                Console.Beep(800, 200);
                Console.Beep(800, 200);
                Console.Beep(800, 200);
                Console.Beep(800, 200);
                Console.Beep(800, 400);
            }

            else if (lettre == '5')
            {
                Console.Write("..... ");
                Console.Beep(800, 200);
                Console.Beep(800, 200);
                Console.Beep(800, 200);
                Console.Beep(800, 200);
                Console.Beep(800, 200);
            }

            else if (lettre == '6')
            {
                Console.Write("-.... ");
                Console.Beep(800, 400);
                Console.Beep(800, 200);
                Console.Beep(800, 200);
                Console.Beep(800, 200);
                Console.Beep(800, 200);
            }

            else if (lettre == '7')
            {
                Console.Write("--... ");
                Console.Beep(800, 400);
                Console.Beep(800, 400);
                Console.Beep(800, 200);
                Console.Beep(800, 200);
                Console.Beep(800, 200);
            }

            else if (lettre == '8')
            {
                Console.Write("---.. ");
                Console.Beep(800, 400);
                Console.Beep(800, 400);
                Console.Beep(800, 400);
                Console.Beep(800, 200);
                Console.Beep(800, 200);
            }

            else if (lettre == '9')
            {
                Console.Write("----. ");
                Console.Beep(800, 400);
                Console.Beep(800, 400);
                Console.Beep(800, 400);
                Console.Beep(800, 400);
                Console.Beep(800, 200);
            }

            else if (lettre == ' ')
            {
                Console.Write("/ ");
            }

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
