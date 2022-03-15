using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_MetotGenelTanim
{
    public class Ogrenci
    {
        public void selamlaOgrenci()
        {
            Console.WriteLine("Merhaba Öğrenci");
        }

        private void ogrenciMetot1(string ogrenciAdi, string ogrenciSoyadi)
        {
            Console.WriteLine("Öğrenci Bilgileri : {0} {1}", ogrenciAdi, ogrenciSoyadi);
        }

        public void ogrenciMetot2()
        {
            ogrenciMetot1("Furkan", "Çiftci");
        }

        public string adGetir()
        {
            return " ";
        }

    }
    /* [ErişimBelirleyicisi] <GeriDonusDegeri> MetotAdi(Parametreler)
     * {
     *      //Metot için gereken kodlar
     * }
     * 
     * Public
     * Private
     * Protected
     * Internal
     * Internal Protected
    */

   


}
