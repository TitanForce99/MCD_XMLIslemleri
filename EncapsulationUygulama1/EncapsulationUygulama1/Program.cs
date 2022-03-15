using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationUygulama1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Country ulke1 = new Country();
            ulke1.Ad = "türkiye";
            ulke1.Baskent = "Ankara";
            ulke1.Nufus = 80000000;
            ulke1.Parabirimi = "Lira";
            ulke1.Yazdir();

            Country ulke2 = new Country();
            ulke1.Ad = "Avustralya";
            ulke1.Baskent = "Kanberra";
            ulke1.Nufus = 25000000;
            ulke1.Parabirimi = "Avustralya Doları";
            ulke1.Yazdir();

            Country ulke3 = new Country();
            ulke1.Ad = "Japonya";
            ulke1.Baskent = "Tokyo";
            ulke1.Nufus = 125000000;
            ulke1.Parabirimi = "Yen";
            ulke1.Yazdir();


            Console.ReadKey();
            

           
        }
    }
}
