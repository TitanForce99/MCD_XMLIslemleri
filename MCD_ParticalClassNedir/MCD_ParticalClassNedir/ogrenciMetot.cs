using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_ParticalClassNedir
{
    public partial class ogrenci
    {
        /*
         * Kontrol işlemeri: sistem içerisinde ögrenci kayıtlı mı? 71777000;
         * parametre kontrol işlemi: Giriş verileriniz hatalıdır. :71777001;
         * try catch : 71777002;
         * Başarılı : 71777003;
         * 
         * 
         * 71777014;
         * 
         * 
         */
        public int yeniKayit(ogrenci o)
        {
            Console.WriteLine("database kayıt işlemi tamamlandı.");
            return 1;
        }

        public int kayitGuncelle(ogrenci o)
        {
            Console.WriteLine("ogrenci kaydı güncellendi.");
            return 1;
        }

        public int kayitSil(ogrenci o)
        {
            Console.WriteLine("ogrenci kaydı silindi");
            return 1;
        }
    }
}
