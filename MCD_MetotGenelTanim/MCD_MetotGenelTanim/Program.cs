using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_MetotGenelTanim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba");
            Selamla();


            Ogrenci o1 = new Ogrenci();
            o1.ogrenciMetot2();
            o1.selamlaOgrenci();
            // private olduğu için ogrenciMetot1'i çağıramayız!!

            Ogrenci o2 = new Ogrenci();
            o2.ogrenciMetot2();
            o2.selamlaOgrenci();

            Console.ReadLine();
        }

        static void Selamla()
        {
            Console.WriteLine("Merhaba");
        }

        
    }
}
