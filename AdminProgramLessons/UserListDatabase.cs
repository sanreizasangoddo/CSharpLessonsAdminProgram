using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminProgramLessons
{
    internal class UserListDatabase
    {
        private List<User> _userList = new List<User>();

        public UserListDatabase()
        {
            User user1 = new User("Yassir Ouallal", "Drachtenstraat 4", "06 81994295", "yassir.ouallal@gmail.com", 16, "lemonke69420");
            _userList.Add(user1);

            User user2 = new User("Deon Maes", "De Marken", "06 18217017", "deon.maes@gmail.com", 16, "pastapesto962");
            _userList.Add(user2);
        }

        public void AddUser()
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
                    if (!char.IsDigit(c) && c != ' ' || phoneNumber.Length < 10 || phoneNumber.Length > 11)
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

                // Checkt of de email een @-tekentje en ".com" heeft en is gelijk aan of langer dan 15 tekens
                if (!email.Contains("@") || !email.Contains(".com") || email.Length <= 15)
                {
                    Console.Clear();
                    Console.WriteLine("Ongeldige invoer. Email moet de standaard eigenschappen bevatten.");
                }
            }
            while (!email.Contains("@") || !email.Contains(".com") || email.Length <= 15);

            Console.Clear();

            int age;
            Console.WriteLine("Voer uw leeftijd in:");

            // Checkt of age alleen uit cijfers bestaat, lager is dan of gelijk aan 5 en hoger is dan of gelijk aan 123
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

                if (password.Length < 6)
                {
                    Console.Clear();
                    Console.WriteLine("Ongeldige invoer. Wachtwoord moet langer zijn.");
                }
            }
            while (password.Length < 6);

            Console.Clear();

            Console.WriteLine("Klant succesvol toegevoegd! \n");

            User AddNewUser = new User(name, address, phoneNumber, email, age, password);
            _userList.Add(AddNewUser);
        }


        public void ShowUser()
        {
            Console.Clear();

            if (_userList.Count == 0)
            {
                Console.Clear();
                
                Console.WriteLine("Geen klanten gevonden. \n");
            }
            else
            {
                Console.Clear();
                foreach (User user in _userList)
                {
                    user.Display();
                    Console.WriteLine(" ");
                }
            }
        }

        public void EditUser()
        {
            if (_userList.Count == 0)
            {
                Console.Clear();

                Console.WriteLine("Geen klanten gevonden. \n");
            }
            else
            {
                Console.Clear();

                ShowUser();

                Console.WriteLine("Welke klant wil je bewerken? \n");
                Console.WriteLine($"Kies een nummer van 1 tot {_userList.Count}:");
                int index;

                while (!int.TryParse(Console.ReadLine(), out index) || index < 1 || index > _userList.Count)
                {
                    Console.WriteLine("Ongeldige keuze.");
                }

                User user = _userList[index - 1];
                _userList.RemoveAt(index - 1);

                Console.Clear();

                AddUser();
            }
        }

        public void DeleteUser()
        {
            if (_userList.Count == 0)
            {
                Console.Clear();

                Console.WriteLine("Geen klanten gevonden. \n");
            }
            else
            {
                Console.Clear();

                ShowUser();

                Console.WriteLine("Welke klant wil je verwijderen?");
                int index;

                while (!int.TryParse(Console.ReadLine(), out index) || index < 1 || index > _userList.Count)
                {
                    Console.WriteLine("Ongeldige keuze.");
                }

                _userList.RemoveAt(index - 1);

                Console.Clear();

                Console.WriteLine("Klant verwijderd. \n");
            }
        }
    }
}