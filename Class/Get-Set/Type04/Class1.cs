using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Class1
    {
        int nopeus;
        double paikka;

        public int Nopeus { get => nopeus; set => nopeus = value; }
        public double Paikka { get => paikka; set => paikka = value; }

        public void laskePaikka(double aika)
        {
            paikka = nopeus * aika;
        }

        public string Tulosta()
        {
            return $"{nopeus}km/h {paikka}km";
        }
    }
}
