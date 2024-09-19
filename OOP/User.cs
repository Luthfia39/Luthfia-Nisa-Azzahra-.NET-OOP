using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class User
    {
        // Atribut dari User
        public string Nama;
        public string Role;
        public int Emoney;

        // Constructor
        public User(string nama, string role, int emoney)
        {
            Nama = nama;
            Role = role;
            Emoney = emoney;
        }
    }
}
