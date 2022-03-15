using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_KalıtımNedir
{
    public sealed class Egitmen:TemelTip // sealed class :hiçbir sınıf kendisinden türetilemez. 
    {
        public string brans { get; set; }
        public int BransSeviye { get; set; }

        public Egitmen()
        {
            Console.WriteLine("Eğitmen nesnesinin yapıcı metodu çalıştı");
            //IdAtamaIslemi
        }
    }
}
