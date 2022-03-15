using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_StaticNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Static : nesne örneği alınmadan ulaşabildiğimiz metot, field, sınıf...
             * Tip M1 = new Tip();
             * Tip.
             */

            //Stack bölge içerisinde pointer ımız oluştu...
            Ogrenci o1;
            //Stack bölgede pointer oluştuğu zaman static olan bir yapıcı metot çalıştı ve yine class içerisinde tanımlı olan static field, metot static dediğimiz bölgede oluşturuldu.
            Ogrenci.Test2();


            o1 = new Ogrenci();
            //Srack bölgede pointer => kenisini heap bölgede tamamladı.. static olmayan tanımlarını tamamladı..
            o1.Test1();//nesne örneği alıondıktan sonra test1 adındaki metotuma ulaşabildim.

        }
    }
}
