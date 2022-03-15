using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_KapsullemeNedir
{

    //encapsulation : bir nesnenin bazı özellik ve işlevlerini
    //başka sınıflardan ve nesnelerden saklamaktır.
    //encapsulation sayesinde nesneler bilinçsiz kullanımdan korunmuş olur.
    internal class Musteri
    {
        //Class => Field
        int id;

        public Musteri()
        {
            this.id = IDuret();
        }


        public int ID
        {
            get
            {
                return this.id;
            }
            private set
            {
                this.id = value;
            }
        }


        public string isim;
        private string _soyisim;
        public string Soyisim
        {
            get { return this._soyisim; }
            set
            {
                this._soyisim = value;
                this.emailAdres = string.Format("{0}.{1}@hotmail.com", isim, _soyisim);
            }
        }


        //Class => Property
        private string emailAdres;
        public string EmailAdres
        {
            //get;//database veya farklı bir veri kaynagı class çağıran programcıya datayı gösterdiğimiz alan
            //set;//dış dünyadan alınan datanın içerisinde private olarak saklanan field içerisine değer atandığı kısım...

            set
            {
                this.emailAdres = value;
            }

            get
            {
                return this.emailAdres;
            }

        }

        //Ara Odev

        private string _tckimliknumarasi;
        public string TCKimlikNumarasi
        {

            get
            {
                if (_tckimliknumarasi != null)
                    return _tckimliknumarasi.Substring(0, 3);
                else
                    return "";
            }
            set
            {
                if (value.Length == 11)
                {
                    bool bayrak = false;
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool karakterKontrol = char.IsNumber(value[i]);
                        if (karakterKontrol)
                        {
                            //sayısal değer demektir....
                        }
                        else
                        {
                            bayrak = true;
                            break;
                        }
                    }

                    if (bayrak)
                    {
                        Console.WriteLine("TC Kimlik Numarası içindeki değerler sayısal olmalıdır....");
                    }
                    else
                    {
                        this._tckimliknumarasi = value;
                    }
                }
                else
                {
                    Console.WriteLine("TC Kimlik Numarası 11 hane olmalıdır....");
                }

            }
        }

        private int IDuret()
        {
            Random rnd = new Random();
            return rnd.Next(10000, 90000);
        }
    }
}
