using System;

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

// Kelas Admin, turunan dari User
public class Admin : User
{
    // Constructor Admin
    public Admin(string nama, int emoney) : base(nama, "Admin", emoney) { }

    // Method tambah saldo
    public void TambahSaldo(Customer customer, int jumlah)
    {
        customer.Emoney += jumlah;
        Console.WriteLine("Berhasil menambahkan saldo!");
    }
}

// Kelas Customer, turunan dari User
public class Customer : User
{
    // Constructor Customer
    public Customer(string nama, int emoney) : base(nama, "Customer", emoney) { }

    // Method show saldo
    public void LihatSaldo()
    {
        Console.WriteLine("Saldo anda : " + this.Emoney);
    }
}

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
