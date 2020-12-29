using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 kok = new Class1();
            Class2 osa = new Class2();
            osa.Luku = 42;
            kok.LisääOsa(osa);

            Class2 vOsa = new Class2();
            vOsa.Luku = 21;
            kok.LisääVaraosa(vOsa);

            //tulostaa
            Console.WriteLine(  osa.Tulosta());
            Console.WriteLine(  kok.Tulosta());
            Console.WriteLine( vOsa.Tulosta());

        }
    }
}
