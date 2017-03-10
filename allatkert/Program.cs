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
                for (int i = 0; i < 10; i++)
                {
                    Allat al = new Allat();
                    al.Tipus = (AllatTipusok)k;
                    al.Suly = sulyGenerálás(al.Tipus);
                    a.Ketrec[k].Lenyek.Add(al);
                }

            int emberszam = 10;

            for (int i = 0; i < emberszam; i++)
            {
                a.Lenyek.Add(new Ember(rnd.Next(3, 200)));
            }

            a.Listazas();
            Console.ReadKey();

            a.Hekkeles(); // Makik meghekkelik az állatkertet
            a.Listazas();
            Console.ReadKey();

            /*
            for (int i = a.Lenyek.Count; i > 0; i--)
            {
                Eloleny e = a.Lenyek[i - 1];

                if (e.Pockol() == false)
                {
                    a.Ketrec[(int)((Allat)e).Tipus].Lenyek.Add(e);
                    a.Lenyek.RemoveAt(i - 1);
                }
            }*/

            while (true)
            {
                Eloleny e1 = a.Lenyek[rnd.Next(a.Lenyek.Count)];
                bool e1isAllat = e1.Pockol() == false;

                Eloleny e2 = a.Lenyek[rnd.Next(a.Lenyek.Count)];
                bool e2isAllat = !e2.Pockol();

                if (e1 != e2)
                {

                    if (
                        e1isAllat && e2isAllat
                       )
                    {
                        if (e1.Suly < e2.Suly)
                        {
                            e2.Eszik(e1);
                            a.Lenyek.Remove(e1);
                        }
                        else
                        {
                            e1.Eszik(e2);
                            a.Lenyek.Remove(e2);
                        }
                    }
                    else
                        if (
                        (a.Lenyek.Count <= (emberszam + 1)) && (e1isAllat || e2isAllat)
                        )
                    {
                        if (e1isAllat)
                        {
                            e1.Eszik(e2);
                            a.Lenyek.Remove(e2);
                        }
                        else
                        {
                            e2.Eszik(e1);
                            a.Lenyek.Remove(e1);
                        }

                    }
                }
            }

            a.Listazas();
            Console.ReadKey();

            /*
            AllatgondoZoo DánkenMeklód = new AllatgondoZoo();*/
        }
    }
}
