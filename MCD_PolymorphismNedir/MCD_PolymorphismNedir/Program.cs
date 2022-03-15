using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_PolymorphismNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*polymorphism
            Belirlenen şekil sınıfları temel bir sınıftan türetilerek bir sınıf hiyerarşisi oluşturulur.
            Türetilmiş bir sınıftaki uygun methodu çağırmak için temel sınıftaki virtual methodu kullanılır.*/

            Console.WriteLine("Banka seçiniz A / B :");
            ConsoleKeyInfo secim;
            secim = Console.ReadKey();


            if (secim.Key == ConsoleKey.A)
            {
                ABankasi bankam = new ABankasi();
                bankam.BilgileriAl();
                bankam.IndirimOraninaGoreIndirimYap();
            }
            else if (secim.Key == ConsoleKey.B)
            {
                BBankasi bankam = new BBankasi();
                bankam.BilgileriAl();
                bankam.IndirimOraninaGoreIndirimYap();
            }

            Console.ReadKey();
        }
    }
}
