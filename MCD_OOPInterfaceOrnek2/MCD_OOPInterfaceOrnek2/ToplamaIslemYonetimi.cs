using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPInterfaceOrnek2
{
    public class ToplamaIslemYonetimi : Islem, Iislem
    {
       

        public void IslemAdiniGetir()
        {
            Console.WriteLine(IslemTur + "-->" );
        }

        public void IslemYap()
        {
            KullancidanSayiAlveTopla();
        }

        private void KullancidanSayiAlveTopla()
        {
            Console.WriteLine("Sayı1: ");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayı2: ");
            int s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayı3: ");
            int s3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sonuç: " + (s1 + s2 + s3).ToString());
        }

        public ToplamaIslemYonetimi()
        {
            this.IslemTur = IslemTuru.Toplama;
        }


    }
}
