using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_PolymorphismNedir
{
    public class Banka
    {
        public string BankaAdi { get; set; }

        private decimal _alisversitutari = 0;


        public decimal AlisverisTutari { get; set; }

        public void BilgileriAl()
        {
            Console.WriteLine(BankaAdi + " bankasına hoşgeldiniz...");
            Console.WriteLine("Alışveriş Tutarı giriniz: ");

            _alisversitutari = Convert.ToDecimal(Console.ReadLine());
            if (_alisversitutari > 0)
            {
                AlisverisTutari = _alisversitutari;

            }
            else
            {
                throw new Exception("Tutar Sıfırdan büyük olmalıdır.");
            }
        }

        public virtual void IndirimOraninaGoreIndirimYap()
        {
            AlisverisTutari -= AlisverisTutari * 0.20m;
            Console.WriteLine("%20 İndirim uygulandı...");
            Console.WriteLine("Ödenecek Tutar: " + AlisverisTutari);
        }


    }    
}
