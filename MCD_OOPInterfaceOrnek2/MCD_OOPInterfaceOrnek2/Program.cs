using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPInterfaceOrnek2
{
    class Program
    {
        static void Main(string[] args)
        {
            //BLL -> Business Logic Layer
            //Manager olarak tanımlamamızın sebebi N-Tier Katmanlı Mimari dersine şimdiden alışkanlık kazandırmaktır.


            ToplamaIslemYonetimi toplamaManager = new ToplamaIslemYonetimi();
            CikarmaIslemYonetimi cikarmaManager = new CikarmaIslemYonetimi();
            BolmeIslemYonetimi bolmeManager = new BolmeIslemYonetimi();

            //interfacelari tip olarak kullanabiliyoruz.
            Iislem[] Islemler = new Iislem[] { toplamaManager, cikarmaManager, bolmeManager };

            foreach (var item in Islemler)
            {
                item.IslemAdiniGetir();
            }

            Console.WriteLine("\n");
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim == (int)IslemTuru.Toplama)
            {
                toplamaManager.IslemYap();
            }
            else if(secim == (int)IslemTuru.Cikarma)
            {
                cikarmaManager.IslemYap();
            }
            else if(secim == (int)IslemTuru.Bolme)
            {
                bolmeManager.IslemYap();
            }
            else
            {
                Console.WriteLine("Hatalı giriş yapıldı.");
            }
            Console.ReadKey();



        }
    }
}
