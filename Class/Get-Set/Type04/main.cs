using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 autoA = new Class1();
            autoA.Paikka = 0;
            autoA.Nopeus = 85;
            Class1 autoB = new Class1();
            autoB.Paikka = 0;
            autoB.Nopeus = 115;
                        
            //
            // int autonA_nopeus = 85;
            // int autonB_nopeus = 115;
            double ajanhetki = 0; //tunteja
            // double autonA_paikka = 0;
            // double autonB_paikka = 0;
            
            for (int i = 0; i < 20; i++)
            {   autoA.laskePaikka(ajanhetki);
                autoB.laskePaikka(ajanhetki);

                Console.Write(ajanhetki+ " : ");
                Console.Write("AutoA" + autoA.Tulosta() + " - AutoB" + autoB.Tulosta());
                Console.WriteLine(" = " + (autoB.Paikka - autoA.Paikka));
                //Console.Write(  (int) laskePaikka(autonA_nopeus, ajanhetki) + " - " );
                //Console.Write(  (int) laskePaikka(autonB_nopeus, ajanhetki) + " = " ); //sama auto B:lle
                //Console.WriteLine(  (int) laskePaikka(autonB_nopeus,ajanhetki) - laskePaikka(autonA_nopeus,ajanhetki) );
                
                ajanhetki += 0.1; //=6min
            }
        }
        static double laskePaikka(int nopeus, double aika)
        {
            return nopeus * aika;

        }

    }
}
