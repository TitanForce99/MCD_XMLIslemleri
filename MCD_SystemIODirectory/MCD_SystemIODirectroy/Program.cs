using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
namespace MCD_SystemIODirectroy
{
    class Program
    {
        static void Main(string[] args)
        {
            //YeniKlasorOlustur(@"c:/NetworkAkademi"); //veya c://NetworkAkademi2
            // KlasorVarlıkKontrolu(@"c:/networkAkademi2");
            //KlasorSilmeIslemleri(@"c:/networkAkademi2");
            //KlasorTasimaIslemleri(@"c:/networkAkademi2",@"c:/tasımaIslemi"); //ilk girdi taşınan dosya 2. dosyayı kendi olusturur ve ilk dosya oraya taşınır.
            Odev1();
        }
         static void YeniKlasorOlustur(string path)
         {
            DirectoryInfo Di = Directory.CreateDirectory(path); // istediğimiz yerde dosya olusturmamızı sağlar path kısmına yer yazılır.c:/NetworkAkademi2,@"c://NetworkAkademi2",c:\\networkAkademi
         }
        static void KlasorVarlıkKontrolu(string path)
        {
            Console.WriteLine(Directory.Exists(path)); // girilen path de dosya olup olmadıgını sorgular bool ifade verir
        }
        static void KlasorSilmeIslemleri(string path)
        {
            // Directory.Delete(path); //icinde dosya var ise silmez sadece dosyanın içi boş ise siler
            Directory.Delete(path, true); // şu an içinde dosya olsa bile siler
        }
        static void KlasorTasimaIslemleri(string kaynak, string hedef)
        {
            Directory.Move(kaynak, hedef); //dosyayı başka bir yere taşır
        }
        static void Odev1()
        {
            //c sürücüsü içerisinde network akademi adında bir klasor olusturun.olusturmadan önce varlık kontrolü yapın eger klasor var ise silin silerken yine kullanıcıdan silmek istiyormusunuz diye yanıt alın daha sonra olusturun eğer klasor yok ise ,fakat adımların bilgisini ekrana yazdırın
            Console.WriteLine("klasor olusturmak istermisin e/h");
           string cevap = Console.ReadLine();
           
            if (cevap == "e")
            {
                if (Directory.Exists(@"c:/networkAkademi"))
                {
                    Console.WriteLine("dosya zaten var var olan dosya silinsin mi e/h");
                    string cevap2= Console.ReadLine();
                    if (cevap2 == "e")
                    {
                      Directory.Delete(@"c:/networkAkademi");
                        Console.WriteLine("dosya silindi program kapanıyor");
                        Thread.Sleep(2000);
                       
                    }
                    else
                    {
                        Console.WriteLine("işlem bitti program kapanıyor");
                        Thread.Sleep(1000);
                    }
                }
                else
                {
                   Directory.CreateDirectory(@"c:/networkAkademi");
                   
                   Console.WriteLine("netwokAkademi adlı dosya olusturuldu");
                }
            }
            

            
            

            
        }
    }
}
