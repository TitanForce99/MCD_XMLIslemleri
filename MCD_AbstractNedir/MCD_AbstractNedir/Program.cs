using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_AbstractNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Abstract Class’lar, diğer sınıflara base Class olmak için yazılır. Bu nedenle Abstract Class’dan nesne türetilemez.
             * 
             * Telefon Örneği
             *       Dünya’nın en büyük akıllı telefon üreten markalarını düşünelim. Hepsinin üretim aşamaları aynı şekilde ilerlemesine rağmen, telefon üzerinde kullandıkları mimari yapısı ve bileşenler aralarındaki farkları oluşturur. Bu senaryo içerisinde Akıllı telefonlar abstract sınıfları, akıllı telefon üretirken kullanılan yazılım, ekran, diğer mimari yapılar ise abstract metotları ve son olarak markalarda Abstract sınıfımızdan türetilen ana sınıflarımızı simgeler.
             * 
             * Abstract ve Interface Kavramları
             * 
             * Kendimize işi yapacak bir rol model çıkartırız. Nasıl olacağının kurallarını hazırlar ve nesnelerimizde kurallarımızı kullanırız.
             * 
             * Bu bölümde oluşturmuş olduğumuz nesnelerimizi nasıl kurallar ile şartlayabileceğimizi konuşacağız.
             * 
             */

            //temelSinif T1 = new temelSinif();//Abstract class new anahtar kelimesi ile bir örneği alınamaz.

            superMusteri SP1 = new superMusteri();
            SP1.testAbctract();

            musteri M1 = new musteri();
            M1.test();
            M1.testAbctract();

            Console.ReadKey();
        }
    }
}
