using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminProgramLessons
{
    internal class Program
    {
        List<User> userList = new List<User>();

        static void Main(string[] args)
        {
            List<User> userList = new List<User>();
            bool running = true; // bepaalt of het programma blijft draaien

            // Menu blijft draaien totdat gebruiker afsluit
            while (running)
            {
                Console.WriteLine("\n--- KLANT MENU ---");
                Console.WriteLine("1. Klant toevoegen");
                Console.WriteLine("2. Klanten bekijken");
                Console.WriteLine("3. Klant bewerken");
                Console.WriteLine("4. Klant verwijderen");
                Console.WriteLine("5. Zoeken op leeftijd");
                Console.WriteLine("6. Afsluiten");

                Console.WriteLine("\nMaak een keuze:");

                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || choice > 6)
                {
                    Console.WriteLine("Ongeldige invoer: Voer één van de keuzes in.");
                }

                // Bepaalt welke functie wordt uitgevoerd
                switch (choice)
                {
                     case 1:
                         //AddUser();
                         break;

                     case 2:
                         //ShowUser();
                         break;

                     case 3:
                         //EditUser();
                         break;

                     case 4:
                         //DeleteUser();
                         break;

                     case 5:
                         //SearchAge();
                         break;

                     case 6:
                         running = false; // stopt het programma
                         break;
                }
            }
        }
    }
}