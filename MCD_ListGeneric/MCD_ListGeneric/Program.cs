using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MCD_ListGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList Generic versiyonu
            // Generic liste : her türden veri tipi  veya kendi oluşturduğumuz veri tipini Collection(list,array) içinde kullanmaktır.

            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("bir");

            //<T> : T tipi demek .net framework içerisinde olan veya bizim oluşturduğumuz herhangi bir tip demek.

            List<int> listeGeneric = new List<int>();
            listeGeneric.Add(1);
            listeGeneric.Add(2);
            //listeGeneric.Add("uc");
            listeGeneric.Add(2);

            for (int i = 0; i < listeGeneric.Count; i++)
            {
                Console.WriteLine(listeGeneric[i]);
            }

            List<string> isimler = new List<string>();
            isimler.Add("Ali Mert");
            isimler.Add("Esra");
            isimler.Add("Hakan");
            //isimler.Add(1234);

            for (int i = 0; i < isimler.Count; i++)
            {
                Console.WriteLine(isimler[i]);
            }

            List<musteri> musteriListe = new List<musteri>();
            musteriListe.Add(new musteri()
            {
                id = 1,
                isim = "faik",
                soyisim = "turan"
            });

            foreach (musteri item in musteriListe)
            {
                Console.WriteLine(item.isim);
            }



            Console.ReadKey();




        }
    }
}
