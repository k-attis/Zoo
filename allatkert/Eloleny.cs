using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace allatkert
{
    public abstract class Eloleny : Pockolos
    {
        public int Suly { get; set; }

        public void Eszik(Eloleny Eledel)
        {
            throw new System.NotImplementedException();
        }

        public abstract bool Pockol();
    }
}