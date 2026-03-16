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
            UserListDatabase user = new UserListDatabase();
            user.Start();
        }
    }
}