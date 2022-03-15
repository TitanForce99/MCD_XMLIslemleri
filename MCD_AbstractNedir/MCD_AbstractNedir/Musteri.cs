using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_AbstractNedir
{
    public class musteri : temelSinif
    {

        public int musteriID { get; set; }


        public musteri()
        {
            musteriID = 1;
        }


        public override void testAbctract()
        {
            Console.WriteLine("musteri => testAbstract");
        }
    }
}
