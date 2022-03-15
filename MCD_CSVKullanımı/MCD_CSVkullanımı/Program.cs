using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace MCD_CSVkullanımı
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Musteri> musterilerim = new List<Musteri>();
            for (int i = 1; i < 50; i++)
            {
                Musteri temp = new Musteri();
                temp.id = i.ToString();
                temp.isim = FakeData.NameData.GetFirstName();
                temp.soyisim = FakeData.NameData.GetSurname();
                temp.emailAdres =  temp.isim+"."+ temp.soyisim+"@" + FakeData.NetworkData.GetDomain();
                temp.telefonNumarası = FakeData.PhoneNumberData.GetInternationalPhoneNumber();
                musterilerim.Add(temp);
              
            }
            StreamReader SR = new StreamReader(@"c:\CSV\Musteriler.csv");
            CsvHelper.CsvReader Reader = new CsvHelper.CsvReader(SR, System.Globalization.CultureInfo.CurrentCulture);
            List<Musteri> OkunanData = Reader.GetRecords<Musteri>().ToList();

            StreamWriter stream = new StreamWriter(@"c:\CSV\Musteriler.csv");
            CsvHelper.CsvWriter writer = new CsvHelper.CsvWriter(stream, System.Globalization.CultureInfo.CurrentCulture); //içeri kayıtları yazdırdık
          
            writer.WriteHeader(typeof(Musteri));
            writer.NextRecord();
            foreach (Musteri item in musterilerim )
            {
              
                 writer.WriteField(item.id);
                writer.WriteField(item.isim);
                writer.WriteField(item.soyisim);
                writer.WriteField(item.emailAdres);
                writer.WriteField(item.telefonNumarası);
                 writer.NextRecord();
            }
            stream.Close();
        }
    }
}
