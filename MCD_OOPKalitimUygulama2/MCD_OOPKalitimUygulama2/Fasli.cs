using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPKalitimUygulama2
{
    public class Fasli : Insan
    {
        public override void Selamlasma()
        {
            base.Selamlasma();//base kalıtımı yeri temsil eder.
            //base.Selamlasma(); yazıldığında kalıtım alınan classtaki metotda hamgi işlem varsa burada o işlem uygulanır.
            //Yani bu Faslı arkadaş selamün aleyküm ile selam verecek.
        }
    }
}
