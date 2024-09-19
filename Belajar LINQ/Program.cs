using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belajar_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] bootcamp = {
            //"Andi", "Sugeng", "Joko", "Wilson"
            //};

            //var query = from n in bootcamp select n;

            //foreach (string item in query)
            //{
            //    Console.WriteLine(item);
            //}

            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var query2 = from n in numbers where n > 5 orderby n descending select n;

            //foreach (var item2 in query2)
            //{
            //    Console.WriteLine(item2);
            //}

            Random random = new Random();

            int num = random.Next(1, 10);

            int inputUser = Convert.ToInt32(Console.ReadLine());

            //bool tebakan = false;

            while (num != inputUser) {

                inputUser = Convert.ToInt32(Console.ReadLine());
                if (num == inputUser) {
                    Console.WriteLine("Benar!");
                    
                }
                else
                {
                    inputUser = Convert.ToInt32(Console.ReadLine());
                }
            }
            

        }
    }
}
