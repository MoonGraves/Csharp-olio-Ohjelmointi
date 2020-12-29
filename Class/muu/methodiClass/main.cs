using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testi_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Lisätieto lisätieto = new Lisätieto();
            Käyttäjä käyttäjä = new Käyttäjä();

            // aseta käyttäjä-olioon lisätieto
            käyttäjä.AsetaLisätietoa(lisätieto);

            Console.WriteLine(käyttäjä.Tulosta());

            List<int> luvut = new List<int>();            
            luvut.Add(1);
            luvut.Add(5);
            luvut.Add(2);
            luvut.Add(123);
            
            for (int i = 0; i < luvut.Count; i++)
            {
                Console.WriteLine(luvut[i]);
            }

            /*
             foreach ( int prime in luvut)
            {
                Console.WriteLine(prime);
            }
            */

        }
    }
}
