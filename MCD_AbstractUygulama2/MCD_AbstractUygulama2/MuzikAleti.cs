using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_AbstractUygulama2
{
    public abstract class MuzikAleti
    {
        public string MuzikAletiAdi { get; set; }
        public string Markasi { get; set; }

        public abstract void Cal();
    }
}
