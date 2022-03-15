using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPPolimorphismUygulama
{
    public class Dikdortgen : Hesaplama
    {
        public double Yukseklik { get; set; }
        public double Genislik { get; set; }
        public Dikdortgen()
        {
            Yukseklik = 5.3;
            Genislik = 3.4;
        }
        public override double Alan()
        {
            return Yukseklik * Genislik;
        }
    }
}
