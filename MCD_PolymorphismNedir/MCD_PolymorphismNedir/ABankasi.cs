using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_PolymorphismNedir
{
    public class ABankasi : Banka
    {
        public override void IndirimOraninaGoreIndirimYap()
        {
            base.IndirimOraninaGoreIndirimYap();
        }
    }
}
