using System;

namespace UserManagement
{
    class User
    {
        // attribute
        string name = "Luthfia";
        string role = "FE";
        int emoney = 1000000000;

        // method
        public void UserDetail()
        {
            Console.WriteLine("ini detail usernya!");
        }

        // object
        static void Main(string[] args)
        {
            // class = blueprint dari sebuah object
            User user = new User();
            user.UserDetail();
            Console.WriteLine("Nama : " + user.name);
            Console.WriteLine("Role : " + user.role);
            Console.WriteLine("Emoney : " + user.emoney);
        }
    }
}