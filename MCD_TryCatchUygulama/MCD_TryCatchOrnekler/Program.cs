using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_TryCatchOrnekler
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    int a;
            //    Console.Write("Sayı gir: ");
            //    a = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Teşekkürler.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Hata oluştu!");
            //    Console.WriteLine(DateTime.Now);
            //    Console.WriteLine("HATA: " + ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Burası Finally");
            //}

            //#region Try Catch Divide By Zero
            //try
            //{
            //    int bolunen = 200;
            //    int bolen = 0;
            //    int sonuc = bolunen / bolen;
            //    Console.WriteLine(sonuc);
            //}
            //catch (DivideByZeroException ex)
            //{

            //    Console.WriteLine("HATA Sıfıra bölme hatası oluştu!");
            //    Console.WriteLine(DateTime.Now + " " + ex.ToString());
            //}

            //#endregion

            //#region ArgumentException
            //try
            //{
            //    Dictionary<char, string> Kisiler = new Dictionary<char, string>();

            //    Kisiler.Add('K', "Esra");
            //    Kisiler.Add('E', "Ali Mert");

            //    Kisiler.Add('K', "Sena");
            //    Kisiler.Add('E', "Talha");

            //    Kisiler.Add('K', "Gamze");
            //    Kisiler.Add('E', "Serdar");

            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.GetType().Name);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.GetType().Name);
            //}
            
            //#endregion



            try
            {
                int[] dizi = new int[] { 0, 1, 2, 3 };
                Console.WriteLine(dizi[10]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("HATA");
                Console.WriteLine(DateTime.Now);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType().Name);
            }


            Console.ReadKey();
        }
    }
}
