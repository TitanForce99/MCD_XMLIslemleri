using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_MetotAsırıYükleme
{
    class Program
    {
        static void Main(string[] args)
        {
            // metot overloading örnegi
            Console.WriteLine(true);
            decimal toplam = Topla(12M, 45M); // m sadece decimal olduğunu belirtir, consoleda yazmaz
            int toplam2 = Topla(22, 33);
            string toplam3 = Topla("ali", " metin");
            Ekranagoster(toplam);
            Ekranagoster(Topla(22,33)); //istersen bu sekilde de gösterebilirsin
            Ekranagoster(toplam2);
            Ekranagoster(toplam3);

            Console.ReadKey();

        }
        static void Ekranagoster(object o)
        {
            Console.WriteLine(o.ToString());
        }
        static int Topla(int sayi1,int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }
        static decimal Topla(decimal sayi1, decimal sayi2)
        {
            decimal toplam = sayi1 + sayi2;
            return toplam;
        }
        static string Topla(string metin1, string metin2)
        {
            return metin1 + metin2;
        }
    }
}
