using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_SanalMetotNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Sanal Metot Nedir
             * Sanal Metot dediğimiz baseclass içerisinde bulunan bir metotun istenirse türeyen sınıf içerisinde nasıl yeniden şekillenebileceğini inceleyeceğiz.
             * 
             * Kalıtım konusunda tüm nesnelerin object nesnesinden kalıtıldığını ve bazı metotların object nesnesinden bize geldiğini söylemiştik.
             * Sanal metot anlatımına object içerisinde bize standart olarak gelen toString metodunu inceleyerek başlayacağız.
             * Sanal metotlar, X-men filminde bulunan mystique karakterine benzetebiliriz.
             * Ortama göre ken şeklini değiştirebilen bir karakter olması buna bir örnek olabilir.
             * 
             * Object => ToString();
             * Musteri M1 = new Musteri();
             * Object => Musteri
             *           M1.ToString();
             *           
             * Namespace.Musteri
             * 
             * 
             */

            Musteri M1 = new Musteri();
            M1.isim = "Faik";
            M1.soyisim = "Turan";
            string toStringMesaj = M1.ToString();
            Console.WriteLine(toStringMesaj);

            Console.ReadKey();

            //MCD_SanalMetotNedir.Musteri
        }
    }
}
