using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_SanalMetotKullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            televizyon T1 = new televizyon();
            T1.ekranaYaz("Hangisi ? ");


            Console.WriteLine("************");
            urun U1 = new urun();
            U1.ekranaYaz("Merhaba");
            Console.WriteLine("************");
            baseClass B1 = new baseClass();
            B1.ekranaYaz("Merhaba");

            Console.ReadKey();
        }
    }
}
