using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    // Kelas Admin, turunan dari User
    public class Admin : User
    {
        // Constructor untuk Admin
        public Admin(string nama, int emoney) : base(nama, "Admin", emoney) { }

        // Method untuk menambah saldo ke customer
        public void TambahSaldo(Customer customer, int jumlah)
        {
            customer.Emoney += jumlah;
            Console.WriteLine("Berhasil menambahkan saldo!");
        }
    }
}
