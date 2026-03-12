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
            bool running = true; // bepaalt of het programma blijft draaien

            // Menu blijft draaien totdat gebruiker afsluit
            while (running)
            {
                Console.WriteLine("--- KLANT MENU ---");
                Console.WriteLine("1. Klant toevoegen");
                Console.WriteLine("2. Klanten bekijken");
                Console.WriteLine("3. Klant bewerken");
                Console.WriteLine("4. Klant verwijderen");
                Console.WriteLine("5. Zoeken op leeftijd");
                Console.WriteLine("6. Afsluiten");

                Console.WriteLine("\nMaak een keuze:");

                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || choice > 6 || choice == 0)
                {
                    Console.WriteLine("Ongeldige invoer: Voer één van de keuzes in.");
                }

                // Bepaalt welke functie wordt uitgevoerd
                switch (choice)
                {
                     case 1:
                         AddUser();
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

        static void AddUser()
        {
            Console.Clear();
            string naam;
            bool geldig = false;

            while (!geldig)
            {
                Console.WriteLine("Voer uw naam in alstublieft:");
                naam = Console.ReadLine();

                geldig = true;

                foreach (char c in naam)
                {
                    if (!char.IsLetter(c) && c != ' ')
                    {
                        geldig = false;
                        Console.Clear();
                        Console.WriteLine("Ongeldige invoer. Voer letters in alstublieft.");
                        break;
                    }
                }
            }

            Console.Clear();
            Console.WriteLine($"Voer uw adres in alstublieft:");
            string adres = Console.ReadLine();

            Console.Clear();
            string phoneNumber;

            while (!geldig)
            {
                Console.WriteLine("Voer uw telefoonnummer in alstublieft:");
                phoneNumber = Console.ReadLine();

                geldig = true;

                foreach (char c in phoneNumber)
                {
                    if (!char.IsDigit(c))
                    {
                        geldig = false;
                        Console.WriteLine("Ongeldige invoer. Voer een cijfer in alstublieft.");
                        break;
                    }
                }
            }
        }
    }
}