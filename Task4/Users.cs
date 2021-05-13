using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Users
    {
        class User
        {
            public User(string login, string password)
            {
                this.Password = password;
                this.Login = login;
            }
            public string Password { get; set; }
            public string Login { get; set; }
        }


        public static string[] MyArray(string Path)    
        {
            string path = Path;

            if (File.Exists(path))
            
                Console.WriteLine("File found");
                string[] lines = File.ReadAllLines(path);
                return lines;
            

        }
    }
}
