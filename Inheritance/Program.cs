using System;

namespace Inheritance
{
    // parent class
    public class Lingkaran
    {
        double Luas;

        // method
        public int LuasLingkaran(double r) {
            Luas = 3.14 * r * r;
            return (int)Luas;
        }
    }

    // child class
    public class Tabung : Lingkaran
    {
        double volume;

        public Tabung(int t, double r)
        {
            volume = t * this.LuasLingkaran(r);
        }

        public double getVolume()
        {
            return volume;
        }

        static void Main(string[] args)
        {
            Tabung tabung = new Tabung(4, 2);
            Console.WriteLine(tabung.getVolume());

        }
    }
}