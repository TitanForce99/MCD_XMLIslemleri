using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_ParticalClassNedir
{
    public class musteri
    {
        #region Fields
        public int id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string emailAdres { get; set; }
        #endregion

        #region Metot
        public int yeniKayit(musteri m)
        {
            Console.WriteLine("database kayıt işlemi tamamlandı.");
            return 1;
        }

        public int kayitGuncelle(musteri m)
        {
            Console.WriteLine("musteri kaydı güncellendi.");
            return 1;
        }

        public int kayitSil(musteri m)
        {
            Console.WriteLine("musteri kaydı silindi");
            return 1;
        }

        #endregion
    }
}
