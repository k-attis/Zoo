using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace allatkert
{
    public class Allatkert : Tarolo
    {
        public List<Tarolo> Ketrec = new List<Tarolo>();

        public Allatkert()
        {
            for (int i = 0; i < 5; i++)
                Ketrec.Add(new Tarolo());
        }

        public override void Listazas()
        {
            Console.WriteLine("Állakert tartalma:");
            base.Listazas();

            for (int i = 0; i < Ketrec.Count; i++)
            {
                Console.WriteLine("{0}. ketrec tartalma:", i);
                Ketrec[i].Listazas();
            }
        }

        public void Hekkeles()
        {
            foreach (Tarolo t in Ketrec)
            {
                foreach (Eloleny e in t.Lenyek)
                    Lenyek.Add(e);

                t.Lenyek.Clear();
            }
        }
    }
}