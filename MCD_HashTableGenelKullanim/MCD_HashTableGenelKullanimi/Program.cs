using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MCD_HashTableGenelKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable H1 = new Hashtable();

            #region Yeni değer ekleme
            H1.Add("Car", "Araba");
            H1.Add("House", "Ev");

            H1.Add("Cars", "Araba");
            //H1.Add("Cars", "Arabalar");Key değeri benzersiz olmak zorundadır.
            foreach (var item in H1.Values)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Yardımcı Metodlar
            bool Kontrol1 = H1.Contains("House");
            bool Kontrol2 = H1.Contains("Door");
            Console.WriteLine(Kontrol1);
            Console.WriteLine(Kontrol2);

            bool Kontrol3 = H1.ContainsKey("House");
            bool Kontrol4 = H1.ContainsValue("Araba");
            Console.WriteLine(Kontrol3);
            Console.WriteLine(Kontrol4);

            foreach (var item in H1.Keys)
            {
                Console.WriteLine(H1[item]+" "+item);
            }

            H1["House"] = "Villa";

            H1.Remove("Cars");

            Console.WriteLine("***************");
            foreach (var item in H1.Keys)
            {
                Console.WriteLine(H1[item] + " " + item);
            }

            int hastableIcindeToplamKacDegerVar = H1.Count;
            Console.WriteLine(hastableIcindeToplamKacDegerVar);
            H1.Clear();//Koleksiyon içerisindeki tüm datayı temizleriz.
            


            #endregion

            Console.ReadLine();
        }
    }
}
