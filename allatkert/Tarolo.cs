using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace allatkert
{
    public class Tarolo
    {
        public List<Eloleny> Lenyek = new List<Eloleny>();

        public virtual void Listazas()
        {
            foreach (Eloleny e in Lenyek)
            {
                Console.WriteLine("{0} Sulya:{1}", (e.Pockol()) ? ("Ember") : ("Állat"), e.Suly);
            }
        }
    }
}