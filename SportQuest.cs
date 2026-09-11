using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sport_App
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Willkommen bei SportQuest!");
            Console.WriteLine("=================================");
            Console.WriteLine("           SportQuest");
            Console.WriteLine("=================================");
            List<string> trainings = new List<string>();
            int anzahlChallenges = 0;
            bool programmLaeuft = true;

            while (programmLaeuft)
            {
                Console.Clear();

                Console.WriteLine("Willkommen bei SportQuest!");
                Console.WriteLine("=================================");
                Console.WriteLine("           SportQuest");
                Console.WriteLine("=================================");

                Console.WriteLine();

                Console.WriteLine("1. Training hinzufügen");
                Console.WriteLine("2. Training anzeigen");
                Console.WriteLine("3. Challenge erstellen");
                Console.WriteLine("4. Fortschritt anzeigen");
                Console.WriteLine("5. Statistiken anzeigen");
                Console.WriteLine("0. Programm beenden");

                Console.WriteLine();
                Console.WriteLine("Deine Auswahl: ");
                string auswahl = Console.ReadLine();

                if (auswahl == "1")
                {
                    Console.Clear();
                    Console.WriteLine("===== Training hinzufügen =====");
                    Console.WriteLine();

                    Console.WriteLine("Welche Sportart hast du gemacht?");
                    string sportart = Console.ReadLine();

                    Console.WriteLine("Wie lange hast du trainiert?");
                    string dauer = Console.ReadLine();

                    Console.WriteLine("An welchem Datum war da Training?");
                    string datum = Console.ReadLine();

                    string training = sportart + "|" + dauer + "|" + datum;

                    trainings.Add(training);

                    Console.WriteLine();
                    Console.WriteLine("Training wurde erfolgreich gespeichert!");

                    Console.WriteLine();
                    Console.WriteLine("Dein gespeichertes Training!");
                    Console.WriteLine();
                    Console.WriteLine("Dein Training:");
                    Console.WriteLine(training);

                    Console.WriteLine();
                    Console.WriteLine("Drücke Enter, um zum Menü zurückzukehren.");
                    Console.ReadLine();
                }
                else if (auswahl == "2")
                {
                    Console.Clear();

                    Console.WriteLine("===== Deine Trainings =====");
                    Console.WriteLine();

                    if (trainings.Count == 0)
                    {
                        Console.WriteLine("Du hast noch keine Trainings gespeichert.");
                    }
                    else
                    {
                        for (int i = 0; i < trainings.Count; i++)
                        {
                            Console.WriteLine((i + 1) + ". " + trainings[i]);
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Drücke Enter, um zum Menü zurückzukehren.");
                    Console.ReadLine();
                }
                else if (auswahl == "3")
                {
                    Console.Clear();

                    Console.WriteLine("===== Challenge erstellen =====");
                    Console.WriteLine();

                    Console.WriteLine("Wie soll deine Challenge heissen");
                    string challengeName = Console.ReadLine();

                    Console.WriteLine("Was ist dein Ziel?");
                    string challengeZiel = Console.ReadLine();

                    Console.WriteLine("Wie lange soll die Challenge dauern?");
                    string challengeDauer = Console.ReadLine();

                    anzahlChallenges++;

                    Console.WriteLine();
                    Console.WriteLine("Challenge wurde erstellt!");

                    Console.WriteLine();
                    Console.WriteLine("Name: " + challengeName);
                    Console.WriteLine("Ziel: " + challengeZiel);
                    Console.WriteLine("Dauer: " + challengeDauer);

                    Console.WriteLine();
                    Console.WriteLine("Drücke Enter, um zum Menü zurückzukehren.");
                    Console.ReadLine();
                }
                else if (auswahl == "4")
                {
                    Console.Clear();

                    Console.WriteLine("===== Fortschritt =====");
                    Console.WriteLine();

                    Console.WriteLine();


                    Console.WriteLine("Anzahl Trainings:" + trainings.Count);
                    Console.WriteLine("Anzahl Challenges:" + anzahlChallenges);

                    Console.WriteLine();
                    Console.WriteLine("Drücke Enter, um zum Menü zurückzukehren.");
                    Console.ReadLine();
                }
                else if (auswahl == "5")
                {
                    Console.Clear();

                    Console.WriteLine("===== Statistiken =====");
                    Console.WriteLine();
                    Console.WriteLine("Anzahl Trainings:" + trainings.Count);
                    Console.WriteLine("Anzahl Challenges:" + anzahlChallenges);


                    Console.WriteLine();


                    if (trainings.Count > 0)
                    {
                        Console.WriteLine("Du hast bereits Trainings gemacht!");
                    }
                    else
                    {
                        Console.WriteLine("Du hast noch keine Trainings gemacht.");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Drücke Enter, um zum Menü zurückzukehren");
                    Console.ReadLine();
                }
                else if (auswahl == "0")
                {
                    programmLaeuft = false;
                }
                else
                {
                    Console.Clear();

                    Console.WriteLine("Ungültige Auswahl!");
                    Console.WriteLine();
                    Console.WriteLine("Bitte gib eine Zahl von 0 bis 5 ein.");

                    Console.WriteLine();
                    Console.WriteLine("Drücke Enter, um zum Menü zurückzukehren");
                    Console.ReadLine();
                }
            }
                Console.Clear();
                Console.WriteLine("Danke, dass du SportQuest benutzt hast!");
        }
    }
}
