using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_PolymorphismNedir
{
    public class BBankasi : Banka
    {
        //Bu banka 0.05 indirim yapacaj bu nedenle virtual metodu override ettik.

        public override void IndirimOraninaGoreIndirimYap()
        {
            AlisverisTutari -= AlisverisTutari * 0.05m;
            Console.WriteLine("%5 indirim uygulandı...");
            Console.WriteLine("Ödenecek Tutar: " + AlisverisTutari);
        }

    }
}
