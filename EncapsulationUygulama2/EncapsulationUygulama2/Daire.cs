using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationUygulama2
{
    internal class Daire
    {
        private double _r;

        public double R
        {
            get { return _r; }
            set { _r = value; }
        }


        public Daire(double r)
        {
            _r = r;
        }
        public void alanhesapla()
        {
            double alan = _r * _r * 3;
            Console.WriteLine("Alan : " + alan.ToString());
        }
        public void cevreHesapla()
        {
            double cevre = _r * 6;
            Console.WriteLine("Çevre : " + cevre.ToString());
        }

    }
}
