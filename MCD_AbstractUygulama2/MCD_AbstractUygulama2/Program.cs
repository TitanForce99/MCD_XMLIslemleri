using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_AbstractUygulama2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gitar g1 = new Gitar()
            {
                Markasi = "Fender",
                MuzikAletiAdi = "Gitar"
            };

            Flut f1 = new Flut();
            f1.Markasi = "Yamaha";
            f1.MuzikAletiAdi = "Flut";

            Muzisyen m1 = new Muzisyen();
            m1.AdiSoyadi = "Onur Şan";
            m1.CaldigiMuzikAleti = g1;

            Muzisyen m2 = new Muzisyen
            {
                CaldigiMuzikAleti = f1,
                AdiSoyadi = "Leman San"
            };

            Console.WriteLine(m1.AdiSoyadi + " " + m1.CaldigiMuzikAleti.MuzikAletiAdi + " çalıyor....");
            m1.CaldigiMuzikAleti.Cal();

            Console.WriteLine(m2.AdiSoyadi + " " + m2.CaldigiMuzikAleti.MuzikAletiAdi + " çalıyor....");
            m2.CaldigiMuzikAleti.Cal();

            Console.ReadKey();

        }
    }
}
