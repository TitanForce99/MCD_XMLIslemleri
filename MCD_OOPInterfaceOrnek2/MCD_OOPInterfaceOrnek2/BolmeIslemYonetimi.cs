using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPInterfaceOrnek2
{
    public class BolmeIslemYonetimi : Islem, Iislem
    {
        

        public void IslemAdiniGetir()
        {
            Console.WriteLine(IslemTur + "-->" );
        }

        public void IslemYap()
        {
            Console.WriteLine("Bölme işlemi yapılacak....");
        }

        public BolmeIslemYonetimi()
        {
            this.IslemTur = IslemTuru.Bolme;
        }




    }
}
