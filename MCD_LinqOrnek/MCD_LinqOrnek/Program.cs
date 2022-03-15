using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_LinqOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Linq --> Language Integrated Query(Dil Entegre Edilmiş Sorgu)

            int[] Sayilar = new int[] { 0, -2, 1, 3, 33, 44, 50, 101 };

            var tekler = from s in Sayilar//nereden hangi koleksiyondan 
                         where s % 2 != 0// where ile koşul belittik
                         select s;
            
            Console.WriteLine("Sayılar dizisindeki tek sayılar");
            foreach (var item in tekler)
            {
                Console.Write(item+ " ");
            }
            Console.WriteLine("\n");
            //2.yöntem
            //Tek satırda linq
            var ciftler = Sayilar.Where(x => x % 2 == 0);
            Console.WriteLine("Sayılar dizisindeki çift sayılar");

            foreach (var item in ciftler)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("****************");
            //Sıfırdan büyük olan çift sayıları getirsin.

            ciftler.ToList().ForEach(x =>
            {
                if (x>0)
                {
                    Console.Write(x + " ");
                }
            });

            Console.WriteLine("\n");




            Console.ReadKey();
        }
    }
}
