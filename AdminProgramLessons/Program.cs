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
        static void Main(string[] args)
        {
            List<User> userList = new List<User>();

            User Yassir = new User("Yassir", "Drachtenstraat 4", "+31 6 81994925", "yassir.ouallal@gmail.com", 16, "lemonke69420");
            User Deon = new User("Deon", "de Marken", "+31 6 18217017", "deon.maes@gmail.com", 16, "pizza");

            userList.Add(Yassir);
            userList.Add(Deon);

            foreach (User user in userList)
            {
                Console.WriteLine(user.Name);
            }
        }
    }
}