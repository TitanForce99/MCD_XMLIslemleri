﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_SanalMetotKullanımı
{
    public class baseClass
    {
        public baseClass()
        {
            Console.WriteLine("base class");
        }

        public virtual void ekranaYaz(string data)
        {
            Console.WriteLine(data);
        }
    }
}
