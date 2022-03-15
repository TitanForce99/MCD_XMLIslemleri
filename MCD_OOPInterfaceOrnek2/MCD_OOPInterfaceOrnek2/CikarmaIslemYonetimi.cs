using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPInterfaceOrnek2
{
    public class CikarmaIslemYonetimi : Islem, Iislem
    {
        

        public void IslemAdiniGetir()
        {
            Console.WriteLine(IslemTur + "-->");
        }

        public void IslemYap()
        {
            //Müşterimiz iki sayının çıkarılma işlemini istiyor.
            //Müşterimiz çıkarma işleminde mutlaka 1. sayının 2.sayıdan büyük olmasını istiyor.

            try
            {
                int a, b;
                SayiDegerleriniAl(out a, out b);
                Console.WriteLine("Sonuç {0}", (a - b).ToString());

            }
            catch (Exception hata)
            {

                Console.WriteLine("Hata oluştu");
                Console.WriteLine(hata.Message);
            }
        }

        private void SayiDegerleriniAl(out int s1, out int s2)
        {
            bool s1kontrol;
            Console.WriteLine("Sayı gir: ");
            s1kontrol = Int32.TryParse(Console.ReadLine(), out s1);

            bool s2kontrol;
            Console.WriteLine("Sayı gir: ");
            s2kontrol = Int32.TryParse(Console.ReadLine(), out s2);

            if (s1kontrol == false)
            {
                throw new FormatException("Sayı girişi başarısız.");
            }

            if (!s2kontrol)
            {
                throw new FormatException("Sayı girişi başarısız.");
            }

            if (s1 < s2)
            {
                throw new FormatException("Birinci sayı ikinci sayıdan büyük girilmelidir!");
            }
        }

        public CikarmaIslemYonetimi()
        {
            this.IslemTur = IslemTuru.Cikarma;
        }


    }
}
