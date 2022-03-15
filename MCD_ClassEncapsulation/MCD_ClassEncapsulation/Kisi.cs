using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_ClassEncapsulation
{
    class Kisi
    {
        public int Id { get; set; }
        private string _adi;
        public string Adi
        {
            get
            {
                string ilkHarf = _adi.Substring(0, 1).ToUpper();
                string gerikalan = _adi.Substring(1).ToLower();
                _adi = ilkHarf + gerikalan;
                return _adi;
            }

            set
            {
                _adi = value;
            }
        }

        private string _soyadi;
        public string Soyadi
        {
            get
            {
                return _soyadi.ToUpper();
            }
            set
            {
                _soyadi = value;
            }
        }

        private int _yas;
        public int Yas
        {
            get
            {
                return _yas;
            }
            //kapsülleme aracılığıyla kontrol edelim. Kurala uymayan bir durum varsa
            //throw ile hata fırlatabiliriz.
            set
            {
                _yas = value;
                if (_yas < 0)
                {
                    _yas = 0;
                    throw new FormatException("Yaş özelliği sıfırdan küçük olamaz");
                }

            }
        }

        public DateTime DogumTarihi { get; set; }

        private string _telefonNumarasi;
        public string TelefonNumarasi
        {
            get
            {
                return _telefonNumarasi.Substring(0, 3) + " "
                    + _telefonNumarasi.Substring(3, 3) + " "
                    + _telefonNumarasi.Substring(6, 2) + " "
                    + _telefonNumarasi.Substring(8, 2);

            }

            set
            {
                char[] dizi = value.ToCharArray();
                bool hepsiRakamMi = true;
                foreach (char item in dizi)
                {
                    if (char.IsNumber(item) == false)
                    {
                        hepsiRakamMi = false;
                        break;
                    }
                }

                if (hepsiRakamMi == true)
                {
                    if (value.ToString().Length == 10)
                    {
                        _telefonNumarasi = value;
                    }
                    else
                    {
                        throw new FormatException("Telefon numarası 10 haneli olmalıdır. 5XXXXXXXXX");
                    }
                }
                else
                {
                    throw new FormatException("Telefon numarası sadece rakamlardan oluşmalıdır.");
                }
            }
        }

        public string DenemeTelNo { get; set; }


    }
}
