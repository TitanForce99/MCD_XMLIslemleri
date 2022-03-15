using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPPolimorphismUygulama
{
    public class Kare : Hesaplama
    {
        public double Uzunluk { get; set; }
        public Kare()
        {
            Uzunluk = 6;
        }
        public override double Alan()
        {
            return Math.Pow(Uzunluk, 2);
        }
    }
}
