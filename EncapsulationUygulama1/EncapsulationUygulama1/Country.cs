using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationUygulama1
{
    internal class Country
    {
        private string _ad;

        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }
        private string _baskent;

        public string Baskent
        {
            get { return _baskent; }
            set { _baskent = value; }
        }
        private int _nufus;

        public int Nufus
        {
            get { return _nufus; }
            set { _nufus = value; }
        }
        private string _parabirimi;

        public string Parabirimi
        {
            get { return _parabirimi; }
            set { _parabirimi = value; }
        }
        
        public void Yazdir()
        {
            Console.WriteLine("Ülke Adı : "+_ad);
            Console.WriteLine("Başkenti : "+_baskent);
            Console.WriteLine("Nüfusu : "+_nufus);
            Console.WriteLine("Para Birimi : "+_parabirimi);
            Console.WriteLine("********************************");
        }


    }
}
