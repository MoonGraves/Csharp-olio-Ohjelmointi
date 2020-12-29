using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 muuttuja = new Class1(213);
            Class1 muuttuja2 = new Class1(999);
            Console.WriteLine(muuttuja.Tulosta());

            Console.WriteLine(Class1.TietojaLuokasta());

            /*
            Static - luokan oma

          -- ei tarvita oliota metodin/propertyn käyttämiseen
          --static tyyppisiä metodeita käytetään joskus
          --static tyyppisiä muuttujie/propertyjä jäytetään harvoin
          --static tyyppisiä luokkia käyte*/

        }
    }
}
