using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Customer : User
    {
        // Constructor untuk Customer
        public Customer(string nama, int emoney) : base(nama, "Customer", emoney) { }

        // Method untuk menampilkan informasi saldo
        public void LihatSaldo()
        {
            Console.WriteLine("Saldo anda : " + this.Emoney);
        }
    }
}
