class1.cs


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Class1
    {
        private string tervehdys2;

        public void Tervehdi(string uusiTervehdys)
        {
            this.tervehdys2 = uusiTervehdys;
        }

        public void Tervehdi()
        {
            Console.WriteLine(this.tervehdys2);
        }

        public void Tervehdi1(string JokuTervehdys)
        {
            Console.WriteLine(JokuTervehdys);
        }

        public string HaeTervehdys()
        {
            return this.tervehdys2;
        }

    }
}


program.cs

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 muuttuja = new Class1();
            muuttuja.Tervehdi("asd");
            Console.WriteLine(muuttuja.HaeTervehdys());
            //muuttuja.HaeTervehdys()) avulla toistaa sen muuttujan.Tervehdi();
            //muuttuja.Tervehdi(); se on sama kuin console.writeline
            //että se tulostuu sen avulla, kaksi vaihtoehtoa jotta tulostuu

            muuttuja.Tervehdi1("123213"); 
            //Tervehdi1. on vaan nimi niin se uusi toisto


            Class1 Nove = new Class1();
            Nove.Tervehdi("moikka");
            Console.WriteLine(Nove.HaeTervehdys());

            Nove.Tervehdi1("moro");


        }
    }
}
