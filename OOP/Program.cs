using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Membuat dua objek Admin dan Customer
            Admin admin = new Admin("Admin", 1000);
            Customer customer1 = new Customer("Mala", 1000);
            Customer customer2 = new Customer("Ria", 1000);

            // Cek role
            Console.Write("Masukkan role anda (admin/customer): ");
            string inputRole = Console.ReadLine();

            do
            {
                switch (inputRole)
                {
                    case ("Admin"):
                        // Input nama cust
                        Console.Write("Masukkan nama customer (Mala/Ria): ");
                        string inputCust = Console.ReadLine();
                        if (inputCust == "Mala")
                        {
                            // Input saldo
                            Console.Write("Masukkan jumlah saldo yang ingin ditambahkan: ");
                            int inputSaldo = Convert.ToInt32(Console.ReadLine());

                            admin.TambahSaldo(customer1, inputSaldo);
                        }
                        else if (inputCust == "Ria")
                        {
                            // Input nama cust
                            Console.Write("Masukkan jumlah saldo yang ingin ditambahkan: ");
                            int inputSaldo = Convert.ToInt32(Console.ReadLine());

                            admin.TambahSaldo(customer2, inputSaldo);
                        }
                        else
                        {
                            Console.WriteLine("Customer tidak ditemukan!");
                        }
                        break;
                    case ("Customer"):
                        Console.Write("Masukkan nama customer (Mala/Ria): ");
                        string inputCustomer = Console.ReadLine();
                        if (inputCustomer == "Mala")
                        {
                            customer1.LihatSaldo();
                        }
                        else if (inputCustomer == "Ria")
                        {
                            customer2.LihatSaldo();
                        }
                        else
                        {
                            Console.WriteLine("Customer tidak ditemukan!");
                        }
                        break;

                }
            }
            while (true);
        }
    }
}

