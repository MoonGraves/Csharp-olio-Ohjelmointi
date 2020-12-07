using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodeja
{
    class Program
    {
        static void Main(string[] args)
        {             
            TulostaTervehdys("Ohjelma käynnissä");
            //string rivi = LueRivi(); //kutsu Console.Readline - metodia
            Console.WriteLine("Summa on " +(LueNumero() + LueNumero() + LueNumero()));
            Console.WriteLine("Kerto on " +(LueNumero() * LueNumero() * LueNumero()));
            Console.WriteLine("Erotus on " +(LueNumero() - LueNumero() - LueNumero()));
            Console.WriteLine("Jako on " + (LueNumero() / LueNumero() / LueNumero()));
        }

        /// <summary>
        /// Lue ja palauta kokonaisluku käyttäjältä 
        /// </summary>
        /// <returns>Luettu numero</returns>
        private static int LueNumero()
        {
            TulostaTervehdys("Anna luku: ");
            string rivi = LueRivi();
            int luku = int.Parse(rivi);
            return luku;
        }


        private static string LueRivi()
        {
            return Console.ReadLine();
        }

        private static void TulostaTervehdys(string teksti)
        {
            Console.WriteLine(teksti);     
        }
    }
}
_________________________

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodeja
{
    class Program
    {
        static void Main(string[] args)
        {             
            TulostaTervehdys("Ohjelma käynnissä");
            //string rivi = LueRivi(); //kutsu Console.Readline - metodia
            Console.WriteLine("Summa on " +(LueNumero() + LueNumero() + LueNumero()));

            int luku = LaskeSumma(1, 4, 7);
            Console.WriteLine("Summa = " +luku);
        }

        /// <summary>
        /// Summa 3 lukua
        /// </summary>
        /// <param name="v1">luku 1</param>
        /// <param name="v2">luku 2</param>
        /// <param name="v3">luku 3</param>
        /// <returns></returns>

        private static int LaskeSumma(int v1, int v2, int v3)
        {
            int luku = v1 + v2 + v3;
            return luku;
            
        }

        /// <summary>
        /// Lue ja palauta kokonaisluku käyttäjältä 
        /// </summary>
        /// <returns>Luettu numero</returns>
        private static int LueNumero()
        {
            TulostaTervehdys("Anna luku: ");
            string rivi = LueRivi();
            int luku = int.Parse(rivi);
            return luku;
        }


        private static string LueRivi()
        {
            return Console.ReadLine();
        }

        private static void TulostaTervehdys(string teksti)
        {
            Console.WriteLine(teksti);     
        }
    }
}

_________________________________________________________________________________
laske kolmion hypotenuusan c pituus (kysyy 2 lukua a ja b). Kaava c = V  (a^2 + b^2)

double a, b, c;
            Console.WriteLine("Eka kateetti ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Toinen kateetti ");
            b = double.Parse(Console.ReadLine());

            c = Math.Sqrt(a * a + b * b);
            Console.WriteLine("Hypotenuussa on : {0}", c);
            Console.ReadLine();
____________________________________________________________________________
print out kaareva ja tms

static void Main(string[] args)
        {

            LaskeSini();
        }

        static void LaskeSini()
        {
            for (int i = 0; i < 75; i++)
            {
                for (int j = 0; j < 10+20+30+40+50*Math.Sin(i/5.0); j++)
                {
                    Console.Write("*"); //samalle riville monta 
                }
                Console.Write("#");
                Console.WriteLine(); //seuraava rivi
            }

        }
_________________________

