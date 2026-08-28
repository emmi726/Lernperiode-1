using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            Console.WriteLine("Deine Auswahl: ");
            string auswahl = Console.ReadLine();
           

            if (auswahl == "1")
            {
                Console.WriteLine("Du möchtest ein Training hinzufügen.");
            }
            else if (auswahl == "2")
            {
                Console.WriteLine("Du möchtest dine Trainings anzeigen.");
            }
            else if(auswahl == "3")
            {
                Console.WriteLine("Du möchtest eine Challenge erstellen.");
            }
            else if (auswahl == "4")
            {
                Console.WriteLine("Du möchtest deinen Fortschritt anzeigen.");
            }
            else if (auswahl == "5")
            {
                Console.WriteLine("Du möchtest deine Statistik anzeigen.");
            }
            else if (auswahl == "0")
            {
                Console.WriteLine("Programm wird beendet!");
            }
            else
            {
                Console.WriteLine("Ungültige Ausgabe!");
            }

            bool programmLaeuft = true;
            while (programmLaeuft) 
            {

            }


        }
    }
}
