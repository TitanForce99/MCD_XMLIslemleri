using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_KalıtımNedir
{
    public class Personel:TemelTip
    {
        public DateTime IsBaslangicTarihi { get; set; }
        public DateTime IsBitisTarihi { get; set; }
        public int IzinGunSayisi { get; set; }
        public Personel()
        {
            Console.WriteLine("personel nesnesi yapıcı metot");
            TemelTipMetot2();
        }

    }
}
