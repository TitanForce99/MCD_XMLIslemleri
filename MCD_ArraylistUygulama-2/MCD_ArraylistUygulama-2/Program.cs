using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MCD_ArraylistUygulama_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array Listte tip yok.
            ArrayList listem = new ArrayList();
            listem.Add("Furkan");
            listem.Add("Çiftci");
            listem.Add("123456789");
            listem.Add('E');
            listem.Add(20);

            listem.Add("Hakan");
            listem.Add("Çiftci");
            listem.Add("123456789");
            listem.Add('E');
            listem.Add(20);

            listem.Add("Süheyla");
            listem.Add("Çiftci");
            listem.Add("123456789");
            listem.Add('K');
            listem.Add(20);

            Console.WriteLine("Array List oluşturuldu.");
            Console.WriteLine("Yazdırılıyor.");
            foreach (var item in listem)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("ArrayList kapasitesi = " + listem.Capacity);
            listem.Remove("Furkan");


            Array.ForEach(listem.ToArray(), x => Console.WriteLine(x));

            Console.ReadKey();

        }
    }
}
