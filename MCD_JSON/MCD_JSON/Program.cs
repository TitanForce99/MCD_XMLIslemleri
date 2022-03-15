using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MCD_JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Personel> personellerim = new List<Personel>();
            for (int i = 0; i < 1000; i++)
            {
                Personel p1 = new Personel();
                p1.ID = Guid.NewGuid();
                p1.isim = FakeData.NameData.GetFirstName();
                p1.soyisim = FakeData.NameData.GetSurname();
               
                p1.emailAdres = $"{ p1.isim}. { p1.soyisim}@ { FakeData.NetworkData.GetDomain()}";
                p1.Telefon = FakeData.PhoneNumberData.GetPhoneNumber();
                personellerim.Add(p1);
            }
            Console.WriteLine("Bilgileriniz json formatında kayıt edilecek.");
            if (Directory.Exists(@"c:\jsonIslemleri\"))
            {

            }
            else
            {
                Directory.CreateDirectory(@"c:\jsonIslemleri\");
                
            }
            string jsonPersonellerim = Newtonsoft.Json.JsonConvert.SerializeObject(personellerim);
            File.WriteAllText(@"c:\jsonIslemleri\Personellerim.json",jsonPersonellerim);
            
            

            
            

        }
    }
}
