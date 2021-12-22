using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace MCD_XMLIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            #region xml data yazma işlemi
            //C:\Users\103AKSAM_BİROL\Source\XML dosyası
            XmlTextWriter xmlwriter = new XmlTextWriter(@"C:\Users\103AKSAM_BİROL\Source\XML dosyası\Personellerim.xml", System.Text.UTF8Encoding.UTF8); //< > 
            xmlwriter.WriteComment("yorumlar buraya yazılır"); //yrum yazma şekli //    <! yorum......>
            //root olusturma
            xmlwriter.WriteStartElement("Personellerim"); //< personellerim>
            //child olusturma
            xmlwriter.WriteStartElement("Personeller"); //<personel>
            //subchild olusturma
            xmlwriter.WriteAttributeString("ID", "1"); // <ID> 1</ID>  hierarchy intensity üst üste sıralı olusuyor
            xmlwriter.WriteElementString("Isim", "Ahmet"); // <Personel
            xmlwriter.WriteElementString("Soyisim", "Koc");
            xmlwriter.WriteElementString("EmailAdres", "Ahmet.Koc@gmail.com");
            xmlwriter.WriteEndElement(); //burada subchild personel kayıt eklemesi kapandı
           //xmlwriter.WriteEndElement(); //burada ise root personellerim kayıt eklemesi kapandı

            //yeni kayıt ekleme
            xmlwriter.WriteStartElement("Personeller");  
            xmlwriter.WriteAttributeString("ID", "2"); 
            xmlwriter.WriteElementString("Isim", "Kenan");
            xmlwriter.WriteElementString("Soyisim", "Işık");
            xmlwriter.WriteElementString("EmailAdres", "Kenan.Işık@gmail.com");
            xmlwriter.WriteEndElement();
            xmlwriter.WriteEndElement();
            xmlwriter.Close();
            #endregion

            #region xml data okutma işlemi
            XmlReader reader = XmlReader.Create(@"C:\Users\103AKSAM_BİROL\Source\XML dosyası\Personellerim.xml");
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    if (reader.MoveToFirstAttribute()) //İLK OKUDUGUN İD Mİ
                    {
                        Console.WriteLine("ID : " + reader.Value.ToString());
                    }
                    //return only when you have START 
                    switch (reader.Name.ToString())
                    {
                        case "Isim":
                            Console.WriteLine("Isim : " + reader.ReadString());
                            break;
                        case "Soyisim":
                            Console.WriteLine("Soyisim : " + reader.ReadString());
                            break;
                        case "EmailAdres":
                            Console.WriteLine("EmailAdres : " + reader.ReadString());
                            Console.WriteLine("");
                            break;
                    }
                }
            }
            Console.ReadLine();
            #endregion
        }
    }
}
