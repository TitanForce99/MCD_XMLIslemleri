using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_DiziOrnekler
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] sayilar = new int[5];
            int sayi, indis;

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(0, 50);
            }

            foreach (int item in sayilar)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Sayı gir : ");
            sayi = Convert.ToInt32(Console.ReadLine());
            indis = Array.IndexOf(sayilar, sayi);//Kullanıcının girdiği sayı dizinin içinde var mı?
            if (indis > -1)
            {
                Console.WriteLine($"Bu değer dizide {indis} indiste vardır.");

            }
            else
            {
                Console.WriteLine("Bu değer dizide YOK!");
            }
        }
    }
}
