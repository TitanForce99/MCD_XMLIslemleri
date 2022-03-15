using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPKalitimUygulama2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alman kisi = new Alman();
            kisi.Ad = "Thomas";
            kisi.Soyad = "Müller";
            Console.WriteLine(kisi.Ad + " şöyle dedi.");
            kisi.Selamlasma();

            Turk kisi2 = new Turk();
            kisi2.Ad = "Faik";
            kisi2.Soyad = "Turan";
            Console.WriteLine(kisi2.Ad + " şöyle dedi.");
            kisi2.Selamlasma();

            Fasli kisi3 = new Fasli();
            kisi3.Ad = "Maryam";
            kisi3.Soyad = "Abdollah";
            Console.WriteLine(kisi3.Ad + " şöyle dedi.");
            kisi3.Selamlasma();

            Ingiliz kisi4 = new Ingiliz();
            kisi4.Ad = "Jennifer";
            kisi4.Soyad = "Lopez";
            Console.WriteLine(kisi4.Ad + " şöyle dedi.");
            kisi4.Selamlasma();

            Console.ReadKey();
        }
    }
}
