using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// menghindari penggunaan nama yang sama (bantu dev memanage codingan)
namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MstProduct product = new MstProduct();
            //product.Name = "BMW M3";
            //product.Description = "BMW M3 Hachback";

            //System.Console.WriteLine("Nama mobil : " + product.Name);
            //System.Console.WriteLine("Deskripsi mobil : " + product.Description);

            //int a = 10;
            //int b = 20;

            //string status = string.Empty;

            //if (a > b)
            //{
            //    status = "nilai a lebih besar dari b";
            //}
            //else if (a < b) 
            //{
            //    status = "nilai a lebih kecil dari b";
            //}
            //else
            //{
            //    status = "nilai a dan b sama";
            //}

            //System.Console.WriteLine(status);

            //string name = "Mala";
            //switch (name) {
            //    case "Mala":
            //        {
            //            Console.WriteLine("namanya " + name);
            //            break;
            //        }
            //        default:
            //        {
            //            Console.WriteLine("gatau");
            //            break;
            //        }
            //}

            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8 };

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }

            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
        }
    }
}
