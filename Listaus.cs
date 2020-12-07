
listan käyttö

List<string> lista = new List<string>();
            lista.Add("tekstiä"); // näitä voi olla monta
            lista.Add("asdfsdf");
            lista.Add("ö12312323");
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }

            // tai for :n sijaan
            foreach(string s in lista) { Console.WriteLine(s); }
            //jos //foreach pälä siitä niin se lisää ton lista.add noi mitä tos on, ni toisen kerran

_________________________________________________________

moodle/listan käyttö

List<string> lista = new List<string>();
            lista.Add("tekstiä"); // näitä voi olla monta
            lista.Add("asdfsdf");
            lista.Add("ö12312323");
            for (int i = 0; i < lista.Count; i++)
            {
                //lista[i] on tyyppiä string
                Console.WriteLine(lista[i]);
            }

            // tai for :n sijaan
            //foreach(string s in lista) { Console.WriteLine(s); }

_______________________________________________________

List<string> lista = new List<string>();
            lista.Add("tekstiä"); // näitä voi olla monta
            lista.Add("toka rivi");
            lista.Add("kolmas");
            for (int i = 0; i < lista.Count; i++)
            {
                //lista[i] on tyyppiä string
                Console.WriteLine(lista[i].ToUpper());
               //To.Upper muuttaa listalla noi kaikki isoiks kirjaimmeksi
            }

            // tai for :n sijaan
            //foreach(string s in lista) { Console.WriteLine(s); }

___________________________________________________________

 List<string> lista = new List<string>();
            lista.Add("tekstiä"); // näitä voi olla monta
            lista.Add("toka rivi");
            lista.Add("kolmas rivi");
            lista.Add("AWSD");

            lista.Sort(); //muuttaa järjestyksen nii kui abcdefg.... ja jne
            for (int i = 0; i < lista.Count; i++)
            {
                //lista[i] on tyyppiä string
                Console.WriteLine(lista[i].ToUpper());
            }

            // tai for :n sijaan
            //foreach(string s in lista) { Console.WriteLine(s); }

____________________________________________________________


List<string> lista = new List<string>();

            //tehtv. kysy listan sisällön käyttäjältä console.readline-metodilla 
            Console.WriteLine("Anna top 5 listat");



            lista.Add("Eka rivi");
            lista.Add("toka rivi");
            lista.Add("awsd");
            lista.Add("Bolo");
            lista.Add("Avo");
            
            //muuttaa siis yo.rivejä

            lista.Sort(); //muuttaa järjestyksen
            for (int i = 0; i < lista.Count; i++)
            {
                //lista[i] on tyyppiä string
                Console.WriteLine(lista[i].ToUpper());
            }

            // tai for :n sijaan
            //foreach(string s in lista) { Console.WriteLine(s); }

toinen versio. käyttäjä kirjoittaa::

List<string> lista = new List<string>();

            //tehtv. kysy listan sisällön käyttäjältä console.readline-metodilla 
            Console.WriteLine("Anna top 5 listat");

            for (int i = 0; i < 5; i++)
            {
                lista.Add(Console.ReadLine()); // näitä voi olla monta
            }
            
            //muuttaa siis yo.rivejä

            lista.Sort(); //muuttaa järjestyksen
            for (int i = 0; i < lista.Count; i++)
            {
                //lista[i] on tyyppiä string
                Console.WriteLine(lista[i].ToUpper());
            }

            // tai for :n sijaan
            //foreach(string s in lista) { Console.WriteLine(s); }

__________________________________________________________

List<string> lista = new List<string>();

            //tehtv. kysy listan sisällön käyttäjältä console.readline-metodilla 
            Console.WriteLine("Anna top 5 listat");

            for (int i = 0; i < 5; i++)
            {
                lista.Add(Console.ReadLine()); // näitä voi olla monta
            }
            
            //muuttaa siis yo.rivejä

            lista.Sort(); //muuttaa järjestyksen abc... ja jne
            lista.Reverse(); //käänteis järjestys
            for (int i = 0; i < lista.Count; i++)
            {
                //lista[i] on tyyppiä string
                Console.WriteLine(lista[i].ToUpper());
            }

            // tai for :n sijaan
            //foreach(string s in lista) { Console.WriteLine(s); }

___________________________________________________________
listan lotto luvun numerot järjestykset

            //lista lisätty 10.9
            List<int> numero = new List<int>(); //lisää
            //teht: a) tulostaa satunnaisluku välilt 1-40
            for (int i = 0; i < 7; i++)
            {
                double luku = r.NextDouble(); // väliltä 0...1 
                numero.Add((int)Math.Floor(luku * 40 + 1));

                //Console.WriteLine("Print " + Math.Floor(luku * 40 + 1));
                // myös r.Next(1,40)
            }

            //tehtv: järjestä, ja tulosta listasta

            numero.Sort();

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Luvun järjestys " +numero[i]);
            }

____________________________________________________________

static void Main(string[] args)
        {
            double luku1 = Math.PI; // 3.141592653589793238462643...
            double luku2 = Math.E;
            // Math.Round pyöristää oikein
            Console.WriteLine(luku1 + " pyöristettynä ylös " + Math.Ceiling(luku1));
            Console.WriteLine(luku2 + " pyöristettynä alaspäin " + Math.Floor(luku2));

            Random r = new Random(); // muka satunnainen luku

            //lista lisätty 10.9
            List<int> numero = new List<int>(); //lisää
            //teht: a) tulostaa satunnaisluku välilt 1-40
            for (int i = 0; i < 7; i++)
            {
                double luku;
                do
                {
                    luku = r.NextDouble(); // väliltä 0...1
                }
                while (numero.Contains((int)Math.Floor(luku * 40 + 1)));
                numero.Add((int)Math.Floor(luku * 40 + 1)); //lisää listaan
                    
                

                //Console.WriteLine("Print " + Math.Floor(luku * 40 + 1));
                // myös r.Next(1,40)
            }

            //tehtv: järjestä, ja tulosta listasta
            numero.Sort();
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Luvun järjestys " +numero[i]);
            }


            // b) Vakioveikkaus 13 * "1","X","2"
            /*
            for (int i = 0; i < 13; i++)
            {
                double luku = r.NextDouble(); // väliltä 0...1 
                if (Math.Floor(luku * 3 + 1) == 3)
                {
                    Console.WriteLine("Veikkaus X");
                }
                else
                {
                    Console.WriteLine("Veikkaus " + Math.Floor(luku * 3 + 1));
                }
                // if...
            }
            */
            
        }

____________________________________________________________

luokka "person"  tee pääohjelmaan lista, jonka jäsenet tyyppiä person
person luokkaan muodostin, jonka parametreinä ovat etunimi ja sukunimi
lisää pääohjelmassa listaan 2 personia, ja tulosta listan sisältö


class1.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Class1
    {
        string firstname;
        string lastname;
           //muodostin


        public Class1()
        {}

        public Class1(string v1, string v2)
        {
            firstname = v1;
            lastname = v2;
        }
        



        public string Tulosta()
        {

            return firstname + " " + lastname;
        }

        public void SetFirstName(string v)
        {
            firstname = v;
        }

        public void SetLastName(string m)
        {
            lastname = m;
        }
    }
}



program .cs


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        //pääohjelma
        static void Main(string[] args)
        {
            List<Class1> lista = new List<Class1>();
            Class1 nimi = new Class1();
            //etu- ja sukunimi
            nimi.SetFirstName("Pena");
            nimi.SetLastName("Avo");
            lista.Add(nimi);
            //toinen vielä

            lista.Add(new Class1("Kilo", "Beech"));

            for (int i = 0; i < lista.Count; i++)
            {
                
                Console.WriteLine(lista[i].Tulosta());
            }

        }
    }
}

_________________________________________________________


file/new project / visual c# / windows desktop / console app(.net framework)
lisää luokka "tulostaja" sekä luokka "pelaaja" (string alias, int pisteet). molempiin muodostimet
tulostaja:an muuttuja tyyppiä Pelaaja

program. cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Pelaaja guru = new Pelaaja();
            guru.Alias = "Guru";
            guru.Pisteet = 100;
           
            Pelaaja p = new Pelaaja();
            p.Alias = "Player1";
            p.Pisteet = 10;
            Tulostaja tulostaja = new Tulostaja();
            tulostaja.setGuru(guru);

            tulostaja.Tulosta(p);
               

            Pelaaja p2 = new Pelaaja();
            p2.Alias = "Player2";
            p2.Pisteet = 5;
            tulostaja.Tulosta(p2);

        }
    }
}


luokka pelaaja. cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Pelaaja
    {
        string alias;
        int pisteet;

        //ctor <tab><tab>
        public Pelaaja()
        {

        }

        public string Alias { get => alias; set => alias = value; }
        public int Pisteet { get => pisteet; set => pisteet = value; }
    }
}


luokka tulostaja .cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Tulostaja
    {
        Pelaaja edellinen;
        Pelaaja guru;

        public void setGuru(Pelaaja g)
        {
            guru = g;
        }


        public Tulostaja()
        {
            edellinen = new Pelaaja();
        }


        internal void Tulosta(Pelaaja p)
        {
            if(edellinen.Pisteet > p.Pisteet)
            {
                Console.WriteLine("Huonompi kuin " + edellinen.Alias);
                //console.wrieline("huonompi kuin edellinen");
            }
            
            if(guru.Pisteet > p.Pisteet)
            {
                Console.WriteLine("Huonompi kuin guru");
            }
                Console.WriteLine("="+p.Alias);
            
            edellinen.Pisteet = p.Pisteet;
            edellinen.Alias = p.Alias;
            
        }
    }
}

