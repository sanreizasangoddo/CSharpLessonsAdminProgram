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
        private int _password;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Adress
        {
            get { return _adress; }
            set { _adress = value; }
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

        public int Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public User(string name, string adress, string phoneNumber, string email, int age, int password)
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