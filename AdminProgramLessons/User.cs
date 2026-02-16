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