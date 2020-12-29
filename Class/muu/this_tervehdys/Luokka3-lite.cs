Tervehtijä-luokkaan metodi void AsetaTervehdys(string uusiTervehdys) - se asettaa "tervehdys"-muuttujan arvon
Toteuta luokkaan myös metodit void Tervehdi() ja void Tervehdi(string omaTervehdys), jotka tulostavat tervehdyksen (tervehdys tai omaTervehdys -muuttujan arvolla)
Toteuta luokkaan vielä metodi string HaeTervehdys(), joka palauttaa (=return) luokan "tervehdys"-muuttuja


class1.cs 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Class1
    {
        //Tämä muuttuja on protected
        //eli siihen ei pääse suoraan käsiksi luokan ulkopuolelta
        //mutta se priytyy jos luokasta periytetään uusi luokka

        protected string terhvehdys;
        private string tervehdys;

        //'public' tarkoittaa, että metodiin päästään käsiksi
        //myös luokan ulkopuolelta, eli se on julkinen.
        //'void' takroitta, että metodi ei palauta mitään

        public void AsetaTervehdys(string omaTervehdys)
        {
            //'this'- avainsana viittaa tähän luokkaan
            //pythonissa vastaava sana on 'self'
            this.tervehdys = omaTervehdys;
        }

        public void Tervehdi()
        {
            Console.WriteLine(this.tervehdys);
        }

        public void Tervehdi(string omaTervehdys)
        {
            Console.WriteLine(omaTervehdys);
        }

        public string HaeTervehdys()
        {
            return this.tervehdys ;
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

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 muuttuja = new Class1();

            muuttuja.AsetaTervehdys("Moikka!");
            Console.WriteLine(muuttuja.HaeTervehdys());
            //toistaa uudestaan siis ton muuttuja.AsetaTervehdys

            muuttuja.Tervehdi();
            muuttuja.Tervehdi("Hei!");
            

            Class1 celsius = new Class1();
            celsius.AsetaTervehdys("moi");
            celsius.Tervehdi("Moro");



        }
    }
}
