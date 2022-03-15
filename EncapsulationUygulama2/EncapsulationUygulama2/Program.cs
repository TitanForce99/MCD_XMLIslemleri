using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationUygulama2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("lütfen alan ve çevre hesabı yapmak istediğiniz dairenin yarıçap değerini giriniz");
            double x = double.Parse(Console.ReadLine());
            Daire d1 = new Daire(x);
            d1.alanhesapla();
            d1.cevreHesapla();


            Console.ReadKey();
        }
    }
}
