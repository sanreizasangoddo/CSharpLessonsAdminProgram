using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminProgramLessons
{
    internal class User
    {
        private string _name;
        private string _adress;
        private string _phoneNumber;
        private string _email;
        private int _age;
        private string _password;

        public string Name
        {
            get { return _name; }
        }

        public string Adress
        {
            get { return _adress; }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
        }

        public string Email
        {
            get { return _email; }
        }

        public int Age
        {
            get { return _age; }
        }

        public string Password
        {
            get { return _password; }
        }

        public User(string name, string adress, string phoneNumber, string email, int age, string password)
        {
            _name = name;
            _adress = adress;
            _phoneNumber = phoneNumber;
            _email = email;
            _age = age;
            _password = password;
        }
    }
}