using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace allatkert
{
    public class Ember : Eloleny
    {
        public Ember(int Suly)
        {
            this.Suly = Suly;
        }

        public override bool Pockol()
        {
            return true;
        }
    }
}