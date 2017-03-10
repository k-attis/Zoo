using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace allatkert
{
    public class Allat : Eloleny
    {
        public AllatTipusok Tipus { get; set; }

        public override bool Pockol()
        {
            return false;
        }
    }
}