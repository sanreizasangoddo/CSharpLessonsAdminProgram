using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminProgramLessons
{
    internal class UserListDatabase
    {
        List<User> userList = new List<User>();

        public void Start()
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

        void AddUser()
        {
            Console.Clear();

            string naam = "";
            bool geldig = false;

            while (!geldig)
            {
                Console.WriteLine("Voer uw naam in alstublieft:");
                naam = Console.ReadLine();

                geldig = true;

                // Checkt of er geen cijfers in jouw naam staan
                foreach (char c in naam)
                {
                    if (!char.IsLetter(c) && c != ' ')
                    {
                        geldig = false;
                        Console.Clear();
                        Console.WriteLine("Ongeldige invoer. Alleen letters toegestaan.");
                        break;
                    }
                }
            }
            Console.Clear();

            Console.WriteLine("Voer uw adres in:");
            string adres = Console.ReadLine();

            Console.Clear();

            string phoneNumber = "";
            geldig = false;

            while (!geldig)
            {
                Console.WriteLine("Voer uw telefoonnummer in:");
                phoneNumber = Console.ReadLine();

                geldig = true;

                // Checkt of er geen letters in jouw telefoonnummer staan
                foreach (char c in phoneNumber)
                {
                    if (!char.IsDigit(c) && c != ' ')
                    {
                        geldig = false;
                        Console.Clear();
                        Console.WriteLine("Ongeldige invoer. Alleen cijfers toegestaan.");
                        break;
                    }
                }
            }

            Console.Clear();
            string email;
            do
            {
                Console.WriteLine("Voer uw email in:");
                email = Console.ReadLine();

                if (!email.Contains("@") && !email.Contains(".com"))
                {
                    Console.Clear();
                    Console.WriteLine("Ongeldige invoer. Email moet de standaard eigenschappen bevatten.");
                }
            }
            while (!email.Contains("@") && !email.Contains(".com"));

            Console.Clear();
            int age;
            Console.WriteLine("Voer uw leeftijd in:");

            while (!int.TryParse(Console.ReadLine(), out age) || age <= 5 || age >= 123)
            {
                Console.WriteLine("Ongeldige invoer. Voer een geldig leeftijd in.");
            }

            Console.Clear();
            string password;

            do
            {
                Console.WriteLine("Maak een wachtwoord (minimaal 6 tekens):");
                password = Console.ReadLine();

                if(password.Length < 6)
                {
                    Console.Clear();
                    Console.WriteLine("Ongeldige invoer. Wachtwoord moet langer zijn.");
                }
            }
            while (password.Length < 6);
            Console.Clear();
        }
    }
}