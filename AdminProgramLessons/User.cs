using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AdminProgramLessons
{
    internal class User
    {
        private string _name;
        private string _address;
        private string _phoneNumber;
        private string _email;
        private int _age;
        private string _password;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public User(string name, string address, string phoneNumber, string email, int age, string password)
        {
            _name = name;
            _address = address;
            _phoneNumber = phoneNumber;
            _email = email;
            _age = age;
            _password = password;
        }

        // Hoe de klant wordt weergegeven
        public void Display()
        {
            Console.WriteLine($"Naam: {Name}");
            Console.WriteLine($"Adres: {Address}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Leeftijd: {Age}");
            Console.WriteLine($"Telefoonnummer: {PhoneNumber}");
        }
    }
}