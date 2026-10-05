using System;
class Program
{
    // Bip Morse
    const int FrequenceBeep = 800;
    const int DureePoint = 200;
    const int DureeTiret = 400;

    static void Main()
    {
        string choix;

        // Menu principal
        do
        {
            Console.WriteLine("=== Couteau Suisse - Utilitaires ===");
            Console.WriteLine("1. Convertir du texte en code Morse");
            Console.WriteLine("2. Convertir des nombres entre différentes bases (Décimal / Binaire / Octal)");
            Console.WriteLine("3. (à venir)");
            Console.Write("Veuillez entrer votre choix : ");
            choix = Console.ReadLine();

            if (choix != "1" && choix != "2" && choix != "3")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nVeuillez entrer un choix valide (1 à 3)\n");
                Console.ResetColor();
            }

        } while (choix != "1" && choix != "2" && choix != "3");

        // Convertir du texte en code Morse
        if (choix == "1")
        {
            Console.WriteLine("");
            Console.WriteLine("=== Convertisseur de texte en code Morse ===");
            Console.WriteLine("Entrez un mot ou une phrase (sans accents, lettres A-Z) :");

            string texte = Console.ReadLine();
            string texteMajuscule = texte.ToUpper(); // Met tout le texte écrit pas l'utilisateur en Majuscule

            Console.WriteLine("Résultat en Morse :");

            foreach (char lettre in texteMajuscule)
            {
                if (lettre == 'A')
                {
                    Console.Write(".- ");
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureeTiret);
                }

                else if (lettre == 'B')
                {
                    Console.Write("-... ");
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureePoint);
                }

                else if (lettre == 'C')
                {
                    Console.Write("-.-. ");
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureePoint);
                }

                else if (lettre == 'D')
                {
                    Console.Write("-.. ");
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureePoint);
                }

                else if (lettre == 'E')
                {
                    Console.Write(". ");
                    Console.Beep(FrequenceBeep, DureePoint);
                }

                else if (lettre == 'F')
                {
                    Console.Write("..-. ");
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureePoint);
                }

                else if (lettre == 'G')
                {
                    Console.Write("--. ");
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureePoint);
                }

                else if (lettre == 'H')
                {
                    Console.Write(".... ");
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureePoint);
                }

                else if (lettre == 'I')
                {
                    Console.Write(".. ");
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureePoint);
                }

                else if (lettre == 'J')
                {
                    Console.Write(".--- ");
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureeTiret);
                }

                else if (lettre == 'K')
                {
                    Console.Write("-.- ");
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureeTiret);
                }

                else if (lettre == 'L')
                {
                    Console.Write(".-.. ");
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureePoint);
                }

                else if (lettre == 'M')
                {
                    Console.Write("-- ");
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureeTiret);
                }

                else if (lettre == 'N')
                {
                    Console.Write("-. ");
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureePoint);
                }

                else if (lettre == 'O')
                {
                    Console.Write("--- ");
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureeTiret);
                }

                else if (lettre == 'P')
                {
                    Console.Write(".--. ");
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureePoint);
                }

                else if (lettre == 'Q')
                {
                    Console.Write("--.- ");
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureeTiret);
                }

                else if (lettre == 'R')
                {
                    Console.Write(".-. ");
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureePoint);
                }

                else if (lettre == 'S')
                {
                    Console.Write("... ");
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureePoint);
                }

                else if (lettre == 'T')
                {
                    Console.Write("- ");
                    Console.Beep(FrequenceBeep, DureeTiret);
                }

                else if (lettre == 'U')
                {
                    Console.Write("..- ");
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureeTiret);
                }

                else if (lettre == 'V')
                {
                    Console.Write("...- ");
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureeTiret);
                }

                else if (lettre == 'W')
                {
                    Console.Write(".-- ");
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureeTiret);
                }

                else if (lettre == 'X')
                {
                    Console.Write("-..- ");
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureeTiret);
                }

                else if (lettre == 'Y')
                {
                    Console.Write("-.-- ");
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureeTiret);
                }

                else if (lettre == 'Z')
                {
                    Console.Write("--.. ");
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureePoint);
                }

                else if (lettre == '0')
                {
                    Console.Write("----- ");
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureeTiret);
                }

                else if (lettre == '1')
                {
                    Console.Write(".---- ");
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureeTiret);
                }

                else if (lettre == '2')
                {
                    Console.Write("..--- ");
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureeTiret);
                }

                else if (lettre == '3')
                {
                    Console.Write("...-- ");
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureeTiret);
                }

                else if (lettre == '4')
                {
                    Console.Write("....- ");
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureeTiret);
                }

                else if (lettre == '5')
                {
                    Console.Write("..... ");
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureePoint);
                }

                else if (lettre == '6')
                {
                    Console.Write("-.... ");
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureePoint);
                }

                else if (lettre == '7')
                {
                    Console.Write("--... ");
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureePoint);
                }

                else if (lettre == '8')
                {
                    Console.Write("---.. ");
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureePoint);
                    Console.Beep(FrequenceBeep, DureePoint);
                }

                else if (lettre == '9')
                {
                    Console.Write("----. ");
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureeTiret);
                    Console.Beep(FrequenceBeep, DureePoint);
                }

                else if (lettre == ' ')
                {
                    Console.Write("/ ");
                }

                else // Si la lettre entrée par l'utilisateur n'est pas entre A-Z et 0-1 alors le programme met une erreur et s'arrête
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

        // Convertir des nombres entre différentes bases (Décimal <> Binaire <> Octal)
        if (choix == "2")
        {
            string choixConvertisseur;

            do
            {
                Console.WriteLine("");
                Console.WriteLine("=== Convertisseur de bases ===");
                Console.WriteLine("1. Décimal > Binaire");
                Console.WriteLine("2. Binaire > Décimal");
                Console.WriteLine("3. Binaire > Octal");
                Console.WriteLine("4. Octal > Binaire");
                Console.Write("Veuillez entrer votre choix : ");
                choixConvertisseur = Console.ReadLine();

                if (choixConvertisseur != "1" && choixConvertisseur != "2" && choixConvertisseur != "3" && choixConvertisseur != "4")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Veuillez entrer un choix valide (1 à 3)");
                    Console.ResetColor();
                }

            } while (choixConvertisseur != "1" && choixConvertisseur != "2" && choixConvertisseur != "3" && choixConvertisseur != "4");

            if (choixConvertisseur == "1")
            {
                // Décimal à binaire
                Console.Write("Entrez un nombre décimal : ");
                int nombreDecimal = int.Parse(Console.ReadLine());

                string resultat = "";

                while (nombreDecimal > 0)
                {
                    int reste = nombreDecimal % 2;
                    resultat = reste + resultat;

                    // On divise par 2
                    nombreDecimal = nombreDecimal / 2;
                }

                Console.WriteLine("Résultat : " + resultat);
            }

            if (choixConvertisseur == "2")
            {
                // Binaire à décimal
                Console.Write("Entrez un nombre binaire : ");
                string nombreBinaire = Console.ReadLine();

                do
                {
                    // Vérifie si le nombre est bien binaire
                    for (int i = 0; i < nombreBinaire.Length; i++)
                    {
                        if (nombreBinaire[i] != '0' && nombreBinaire[i] != '1')
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Veuillez entrer que des valeurs de 1 ou 0");
                            Console.ResetColor();

                            Console.Write("Entrez un nombre binaire : ");
                            nombreBinaire = Console.ReadLine();

                            break;
                        }
                    }
                } while (nombreBinaire.Contains("2"));

                int resultat = 0;
                int puissance = 1;

                // Convertit binaire en décimal
                for (int i = nombreBinaire.Length - 1; i >= 0; i--)
                {
                    if (nombreBinaire[i] == '1')
                    {
                        resultat = resultat + puissance;
                    }

                    puissance = puissance * 2;
                }

                Console.WriteLine("Résultat : " + resultat);
            }

            if (choixConvertisseur == "3")
            {
                // Binaire à octal
                Console.Write("Entrez un nombre Binaire : ");
                string nombreBinaireOctal = Console.ReadLine();

                do
                {
                    // Vérifie si le nombre est bien binaire
                    for (int i = 0; i < nombreBinaireOctal.Length; i++)
                    {
                        if (nombreBinaireOctal[i] != '0' && nombreBinaireOctal[i] != '1')
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Veuillez entrer que des valeurs de 1 ou 0");
                            Console.ResetColor();

                            Console.Write("Entrez un nombre binaire : ");
                            nombreBinaireOctal = Console.ReadLine();

                            break;
                        }
                    }
                } while (nombreBinaireOctal.Contains("2"));

                int resultat = 0;
                int puissance = 1;

                // Convertit le binaire en décimal
                for (int i = nombreBinaireOctal.Length - 1; i >= 0; i--)
                {
                    if (nombreBinaireOctal[i] == '1')
                    {
                        resultat += puissance;
                    }

                    puissance *= 2;
                }

                // Convertit le décimal en octal
                string nombreOctal = "";

                do
                {
                    int reste = resultat % 8;
                    nombreOctal = reste + nombreOctal;
                    resultat /= 8;
                } while (resultat > 0);

                Console.WriteLine("Résultat : " + nombreOctal);
            }

            if (choixConvertisseur == "4")
            {
                // Octal à binaire
                Console.Write("Entrez un nombre en Octal : ");
                string nombreOctalBinaire = Console.ReadLine();

                string resultat = "";

                for (int i = 0; i < nombreOctalBinaire.Length; i++)
                {
                    int nombre = nombreOctalBinaire[i] - '0';
                    string binaire = "";

                    // On transforme le chiffre octal en binaire
                    while (nombre > 0)
                    {
                        int reste = nombre % 2;
                        binaire = reste + binaire;
                        nombre = nombre / 2;
                    }

                    // On ajoute les 0 manquants
                    while (binaire.Length < 3)
                    {
                        binaire = "0" + binaire;
                    }

                    resultat = resultat + binaire;
                }

                Console.WriteLine("Résultat : " + resultat);
            }
        }
    }
}