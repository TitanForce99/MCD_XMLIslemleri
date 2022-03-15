using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPPolimorphismUygulama
{
    public class Cember : Hesaplama
    {
        public double YariCap { get; set; }
        public Cember()
        {
            YariCap = 5;
        }
        public override double Alan()
        {
            return (3.14) * Math.Pow(YariCap, 2);
        }
    }
}
