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
            Console.WriteLine("Eszik {0},súly{1} Eledel {2},súly{3}",
                (this.Pockol()) ? ("Ember") : ("Állat"),
                this.Suly,
                (Eledel.Pockol()) ? ("Ember") : ("Állat"),
                Eledel.Suly
                );
        }

        public abstract bool Pockol();
    }
}