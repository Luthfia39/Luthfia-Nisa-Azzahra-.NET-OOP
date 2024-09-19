using System;

namespace UserBootcamp
{
    class User
    {
        static void Main(string[] args)
        {
            UserBootcamp11 userBootcamp11 = new UserBootcamp11();
            userBootcamp11.NamaUser = "Surya";

            Console.WriteLine("Nama : " + userBootcamp11.NamaUser);
        }
    }

    public class UserBootcamp11
    {
        string name;
        string role;
        int emoney;

        //public string NamaUser
        //{
        //    get { return name; }
        //    set { name = value; }
        //}

        public string NamaUser { get; set; }

        public string RoleUser
        {
            get { return name; }
            set { name = value; }
        }

        public string Emoney
        {
            get { return name; }
            set { name = value; }
        }
    }
}