using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPInterfaceNedir
{
    public class musteri : Imusteri
    {

        int _id;
        string _isim;
        string _soyisim;

        int Imusteri.Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        string Imusteri.isim
        {
            get
            {
                return _isim;
            }
            set
            {
                _isim = value;
            }
        }
        string Imusteri.soyisim
        {
            get
            {
                return _soyisim;
            }
            set
            {
                _soyisim = value;
            }
        }

        int Imusteri.kayitDuzenle(int id, string isim, string soyisim)
        {
            Console.WriteLine("kayıt duzenlendi...");
            return 1;
        }

        int Imusteri.kayitSil(int id)
        {
            Console.WriteLine("kayıt silindi...");
            return 1;
        }

        int Imusteri.yeniKayit(string isim, string soyisim)
        {
            Console.WriteLine("yeni kayıt eklendi...");
            return 1;
        }
    }
}
