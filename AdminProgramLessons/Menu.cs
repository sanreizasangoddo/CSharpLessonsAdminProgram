using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminProgramLessons
{
    internal class Menu
    {
        private UserListDatabase _userListDatabase = new UserListDatabase();

        public void UserMenu()
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
                    Console.Clear();
                    Console.WriteLine("--- KLANT MENU ---");
                    Console.WriteLine("1. Klant toevoegen");
                    Console.WriteLine("2. Klanten bekijken");
                    Console.WriteLine("3. Klant bewerken");
                    Console.WriteLine("4. Klant verwijderen");
                    Console.WriteLine("5. Zoeken op leeftijd");
                    Console.WriteLine("6. Afsluiten");

                    Console.WriteLine("\nOngeldige invoer: Voer één van de keuzes in.");
                }

                // Bepaalt welke functie wordt uitgevoerd
                switch (choice)
                {
                    case 1:
                        _userListDatabase.AddUser();
                        break;

                    case 2:
                        _userListDatabase.ShowUser();
                        break;

                    case 3:
                        _userListDatabase.EditUser();
                        break;

                    case 4:
                        _userListDatabase.DeleteUser();
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