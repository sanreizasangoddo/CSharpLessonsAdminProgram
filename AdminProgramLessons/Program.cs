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
            User Yassir = new User("Yassir", "Drachtenstraat 4", "+31 6 81994295", "yassir.ouallal@gmail.com", 16, "lemonke69420");
            Yassir.ShowInformation();

            UserList test = new UserList();
            test.Start();
        }
    }
}