using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_StaticOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Müşteri adında bir nesne oluşturalım ve oluşturmuş olduğumuz nesnemizin içerisinde static olarak bir ArrayList oluşturalım.
             * 
             * Oluşturmuş olduğumuz ArrayList koleksiyonumuzu sanal bir database mantığında kullanacağız.
             * Müşteri sınıfımızın içerisine
             * ID, Isim, Soyisim, EmailAdres, KullaniciAdi, Sifre isimleri ile fieldlar oluşturalım.
             * 
             * Oluşturmuş olduğumuz bu field listesinden bazılarının kapsülleme filtreleri aşağıdaki gibi olmalodor.
             * 
             * Kullanici adı değeri sanal olarak oluşturmuş olduğumuz database imiz içerisinde aranan eğer kullanıcı adı sanal database içerisinde bulunursa field içerisine eklemek istenen değer eklenemesin(Kapsülleme)
             * 
             * Müşteri ekle adında static metot oluşturalım parametre olarak  müşteri tipi alsın içerisinde
             * Müşteri nesnesinin null olup olmadığını ve müşteri nesnesi içerisindeki kullanıcı adının dolu olması şartına baksın.
             * Yukarıdaki kriterlerden geçerse müşterimizi sanal olarak oluşturduğumuz database imize eklemeden önce email adresinden bir kontrol sağlasın eğer sistemde aynı email adresi ile müşteri değeri var ise eklemesin yok ise sanal database içerisine ilgili nesneyi eklesin.
             * 
             */

            Musteri M1 = new Musteri();
            M1.musteriID = 1;
            M1.isim = "Faik";
            M1.soyisim = "Turan";
            M1.emailAdres = "faik.turan@hotmail.com";
            M1.KullaniciAdi = "faik.turan";
            M1.sifre = "1";

            Musteri.MusteriEkle(M1);

            Musteri M2 = new Musteri();
           M2.musteriID = 2;
           M2.isim = "Ali";
           M2.soyisim = "Gel";
           M2.emailAdres = "ali.gel@hotmail.com";
           M2.KullaniciAdi = "ali.gel";
           M2.sifre = "2";

            Musteri.MusteriEkle(M2);

            Musteri M3 = new Musteri();
           M3.musteriID = 3;
           M3.isim = "Faik";
           M3.soyisim = "Turan";
           M3.emailAdres = "faik.turan@hotmail.com";
           M3.KullaniciAdi = "faik.turan";
           M3.sifre = "1";

            Musteri.MusteriEkle(M3);

            foreach (Musteri i in Musteri.musteriDatabase)
            {
                Console.WriteLine(i.musteriID);
                Console.WriteLine(i.isim);
                Console.WriteLine(i.soyisim);
                Console.WriteLine(i.KullaniciAdi);
                Console.WriteLine(i.sifre);
                Console.WriteLine(i.emailAdres);
            }


            Console.ReadKey();
        }
    }
}
