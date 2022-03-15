using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_KalıtımNedir
{
    public sealed class Ogrenci:TemelTip
    {
        public string bolum { get; set; }
        public int seviye { get; set; }
        public Ogrenci()
        {
            Console.WriteLine("Öğrenci nesnesi çalıştı.");
            // TemelTipMetot2(); protected olarak işaretlendiği ve TemelTip nesnesinden kalıttığı için;
            // protected seviyesinde olan field veya metotlara erişebilir.
        }
    }
}
