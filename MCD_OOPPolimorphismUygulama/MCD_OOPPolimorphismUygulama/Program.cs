using MCD_OOPPolimorphismUygulama;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPPolymorphismUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hesaplama cember = new Cember();
            Console.WriteLine("Cember Alanı:" + cember.Alan());

            Hesaplama kare = new Kare();
            Console.WriteLine("Kare Alanı:" + kare.Alan());

            Hesaplama dikdortgen = new Dikdortgen();
            Console.WriteLine("Dikdörtgen Alanı :" + dikdortgen.Alan());

            Console.ReadKey();
        }
    }
}
