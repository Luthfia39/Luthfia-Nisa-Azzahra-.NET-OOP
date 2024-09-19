using System;

namespace Encapsulation
{
    public class Lingkaran
    {
        // private field
        private double radius;

        // public property untuk mengakses dan mengatur radius
        public double Radius
        {
            get { return radius; }
            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    throw new ArgumentException("Radius harus lebih dari 0");
                }
            }
        }

        // hitung luas lingkaran
        public double Luas() 
        {
            return 3.14 * radius * radius;
        }
    }

    // class tabung menggunakan class lingkaran sebagai komponen
    public class Tabung
    {
        private Lingkaran lingkaran;
        private double tinggi;
        private double volume;

        public Tabung(double radius, double tinggi)
        {
            lingkaran = new Lingkaran();
            lingkaran.Radius = radius;
            this.tinggi = tinggi;

            volume = tinggi * lingkaran.Luas();
        }

        static void Main(string[] args)
        {
            try
            {
                Tabung tabung = new Tabung(2, 4);
                Console.WriteLine(tabung.volume);
            }
            catch (Exception e) 
            { 
                Console.WriteLine(e.ToString());
            }
        }

    }
}