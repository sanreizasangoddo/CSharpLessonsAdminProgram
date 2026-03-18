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
            User user1 = new User("Yassir Ouallal", "Drachtenstraat 4", "06 81994295", "yassir.ouallal@gmail.com", 16, "lemonke69420");
            userList.Add(user1);

            User user2 = new User("Deon Maes", "De Marken", "06 18217017", "deon.maes@gmail.com", 16, "pastapesto962");
            userList.Add(user2);

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
                        ShowUser();
                        break;

                    case 3:
                        EditUser();
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

            string name = "";
            bool geldig = false;

            while (!geldig)
            {
                Console.WriteLine("Voer uw naam in:");
                name = Console.ReadLine();

                geldig = true;

                // Checkt of er geen cijfers in jouw naam staan
                foreach (char c in name)
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
            string address = Console.ReadLine();

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
                    if (!char.IsDigit(c) && c != ' ' || phoneNumber.Length != 11)
                    {
                        geldig = false;
                        Console.Clear();
                        Console.WriteLine("Ongeldige invoer. Voer een geldige telefoonnummer in.");
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

                if (!email.Contains("@") && !email.Contains(".com") && email.Length <= 15)
                {
                    Console.Clear();
                    Console.WriteLine("Ongeldige invoer. Email moet de standaard eigenschappen bevatten.");
                }
            }
            while (!email.Contains("@") && !email.Contains(".com") && email.Length <= 15);

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
            Console.WriteLine("Klant succesvol toegevoegd! \n");

            User AddUser = new User(name, address, phoneNumber, email, age, password);
            userList.Add(AddUser);
        }

        void ShowUser()
        {
            Console.Clear();

            if (userList.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("--- KLANT MENU ---");
                Console.WriteLine("1. Klant toevoegen");
                Console.WriteLine("2. Klanten bekijken");
                Console.WriteLine("3. Klant bewerken");
                Console.WriteLine("4. Klant verwijderen");
                Console.WriteLine("5. Zoeken op leeftijd");
                Console.WriteLine("6. Afsluiten");

                Console.WriteLine("\nGeen klanten gevonden.");
            }
            else
            {
                Console.Clear();
                foreach (User user in userList)
                {
                    user.Display();
                    Console.WriteLine(" ");
                }
            }
        }

        void EditUser()
        {
            Console.Clear();

            ShowUser();

            Console.WriteLine("Welke klant wil je bewerken?");
            int index;

            while (!int.TryParse(Console.ReadLine(), out index) || index < 1 || index > userList.Count)
            {
                Console.WriteLine("Ongeldige keuze.");
            }

            User user = userList[index - 1];

            Console.Clear();

            bool geldig = false;

            while (!geldig)
            {
                Console.WriteLine("Voer uw nieuwe naam in:");
                user.Name = Console.ReadLine();

                geldig = true;

                // Checkt of er geen cijfers in jouw naam staan
                foreach (char c in user.Name)
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

            Console.WriteLine("Voer uw nieuwe adres in:");
            user.Address = Console.ReadLine();

            Console.Clear();

            geldig = false;

            while (!geldig)
            {
                Console.WriteLine("Voer uw nieuwe telefoonnummer in:");
                user.PhoneNumber = Console.ReadLine();

                geldig = true;

                // Checkt of er geen letters in jouw telefoonnummer staan
                foreach (char c in user.PhoneNumber)
                {
                    if (!char.IsDigit(c) && c != ' ' || user.PhoneNumber.Length != 11)
                    {
                        geldig = false;
                        Console.Clear();
                        Console.WriteLine("Ongeldige invoer. Voer een geldige telefoonnummer in.");
                        break;
                    }
                }
            }

            Console.Clear();

            do
            {
                Console.WriteLine("Voer uw nieuwe email in:");
                user.Email = Console.ReadLine();

                if (!user.Email.Contains("@") && !user.Email.Contains(".com") && user.Email.Length <= 15)
                {
                    Console.Clear();
                    Console.WriteLine("Ongeldige invoer. Email moet de standaard eigenschappen bevatten.");
                }
            }
            while (!user.Email.Contains("@") && !user.Email.Contains(".com") && user.Email.Length <= 15);

            Console.Clear();

            Console.WriteLine("Voer uw nieuwe leeftijd in:");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age) || age <= 5 || age >= 123)
            {
                Console.WriteLine("Ongeldige invoer. Voer een geldig leeftijd in.");
            }
            user.Age = age;

            Console.Clear();

            do
            {
                Console.WriteLine("Maak een nieuwe wachtwoord (minimaal 6 tekens):");
                user.Password = Console.ReadLine();

                if (user.Password.Length < 6)
                {
                    Console.Clear();
                    Console.WriteLine("Ongeldige invoer. Wachtwoord moet langer zijn.");
                }
            }
            while (user.Password.Length < 6);

            Console.Clear();
            Console.WriteLine("Klant aangepast! \n");
        }
    }
}