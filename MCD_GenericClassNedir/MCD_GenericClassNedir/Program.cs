using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_GenericClassNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.id = 1;
            M1.TcKimlikNumarasi = "12254401254";
            M1.musteriNumara = "MS123";
            M1.isim = "Faik";
            M1.soyisim = "Turan";
            M1.DogumTarih = DateTime.Parse("20.07.1978");

            MusteriGeneric<int> MusteriGeneric1 = new MusteriGeneric<int>();
            MusteriGeneric1.id = 1;
            MusteriGeneric1.musteriNumarasiAl();

            MusteriGeneric<Guid> MusteriGeneric2 = new MusteriGeneric<Guid>();
            Console.WriteLine(MusteriGeneric2.musteriNumarasiAl()); 


            Console.ReadKey();




        }
    }
}
