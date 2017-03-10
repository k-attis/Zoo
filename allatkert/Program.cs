using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allatkert
{
    class Program
    {
        static Random rnd = new Random();

        static int sulyGenerálás(AllatTipusok Tipus)
        {
            switch (Tipus)
            {
                case AllatTipusok.Kecske: return rnd.Next(25, 80);
                case AllatTipusok.Cápa: return rnd.Next(500, 800);
                case AllatTipusok.Páwa: return rnd.Next(6, 50);
                case AllatTipusok.Zsiráf: return rnd.Next(70, 600);
                case AllatTipusok.Kakadu: return rnd.Next(1, 8);
            }

            return -1;
        }

        static void Main(string[] args)
        {
            Allatkert a = new Allatkert();

            // generálás
            for (int k = 0; k < 5; k++)
                for (int i = 0; i < 1; i++)
                {
                    Allat al = new Allat();
                    al.Tipus = (AllatTipusok)k;
                    al.Suly = sulyGenerálás(al.Tipus);
                    a.Ketrec[k].Lenyek.Add(al);
                }

            for (int i = 0; i < 10; i++)
            {
                a.Lenyek.Add(new Ember(rnd.Next(3, 200)));
            }

            a.Listazas();
            Console.ReadKey();

            a.Hekkeles(); // Makik meghekkelik az állatkertet
            a.Listazas();
            Console.ReadKey();

            for (int i = a.Lenyek.Count; i > 0; i--)
            {
                Eloleny e = a.Lenyek[i - 1];

                if (e.Pockol() == false)
                {
                    a.Ketrec[(int)((Allat)e).Tipus].Lenyek.Add(e);
                    a.Lenyek.RemoveAt(i - 1);
                }
            }

            a.Listazas();
            Console.ReadKey();

            /*
            AllatgondoZoo DánkenMeklód = new AllatgondoZoo();*/
        }
    }
}
