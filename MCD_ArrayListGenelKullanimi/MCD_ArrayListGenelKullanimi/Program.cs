using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MCD_ArrayListGenelKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList Genel Kullanimi
            //10 elemanlı (strin) ArrayList içindeki değerleri Z-A olacak şekilde sıralayın.
            ArrayList odevListe = new ArrayList();
            odevListe.Add("Fatih");
            odevListe.Add("Esra");
            odevListe.Add("Ali Mert");
            odevListe.Add("Serdar");
            odevListe.Add("Gamze");
            odevListe.Add("Hakan");
            odevListe.Add("Furkan");
            odevListe.Add("Birol");
            odevListe.Add("Cem");
            odevListe.Add("Yakup");

            //Tüm değerleri A-z çevir
            odevListe.Sort();
            odevListe.Reverse();

            foreach (var item in odevListe)
            {
                Console.WriteLine(item);
            }

            int Capacity = 0;
            int Count = 0;

            string[] isimler = new string[10];

            ArrayList A1 = new ArrayList();

            #region Tek Değer Ekleme
            A1.Add("Erdem");
            A1.Add("Talha");
            A1.Add("Sena");
            A1.Add("Ali");
            A1.Add("Veli");
            #endregion

            A1.Add(100);

            Capacity = A1.Capacity;
            Count = A1.Count;

          

            Console.WriteLine(Capacity);
            Console.WriteLine(Count);
            #endregion

            #region Birden fazla değer ekleme işlemi
            ArrayList A2 = new ArrayList();
            A2.Add("Utku");
            A2.Add("Merve");
            A2.Add("Utkan");
            A1.AddRange(A2);

            foreach (var item in A1)
            {
                Console.WriteLine(item);
            }

            #region Koleksiyon içindeki değere ulaşmak
            object o1 = A1[3];
            Console.WriteLine(o1);
            string S1 = A1[3].ToString();
            Console.WriteLine(S1);
            //int I1 = (int)(A1[1]);
            //Console.WriteLine(I1);


            A1[3] = "Hamza Atilla";
            Console.WriteLine(A1[3]);

            #endregion

            #endregion

            #region Dizinin mevcut elemanlarını ters olarak sıralama
            A1.Remove(100);
            A1.Reverse();
            //A-Z Sıralam
            A1.Sort();
            #endregion
            Console.WriteLine("****************");
            foreach (var item in A1)
            {
                
                Console.WriteLine(item);
            }

            #region Koleksiyonlar yardımcı komutları

            if (A1.Contains("Merve"))
            {
                int IndexDegeri = A1.IndexOf("Merve");
                Console.WriteLine(IndexDegeri);
                    A1.RemoveAt(IndexDegeri);
            }
            else
            {
                Console.WriteLine("Böyle bir kişi yoktur!");
            }

            #endregion

            bool Kontrol1 = A1.Contains("Utkan");
            bool Kontrol2 = A1.Contains(900);

            Console.WriteLine("Kontrol1: " +Kontrol1 +" "+ "Kontrol2: " + Kontrol2 + " ");

            object[] D1 = A1.ToArray();

            foreach (var item in D1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*****************");
            //A1.Clear();
            //foreach (var item in A1)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("*****************");
            //A1.Add("Defne");
            //foreach (var item in A1)
            //{
            //    Console.WriteLine(item);
            //}
            //A1.TrimToSize();
            //foreach (var item in A1)
            //{
            //    Console.WriteLine(item);
            //}
            Console.WriteLine("******************");
            #region ArrayList koleksiyonu içerisindeki değeri silme
            A1.RemoveAt(3);
            foreach (var item in A1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("******************");
            A1.RemoveRange(2, 2);
            foreach (var item in A1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("******************");
            A1.Remove("Hamze Atilla");

            #endregion

            Console.ReadLine();
            
        }
    }
}
