using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123
{
    class Program
    {
        static void Main(string[] args)
        {

            //alku asiakkaan yhteistiedot

            int numero;
            string nimi;
            string sposti;
            int pnumero;


            //hinnan tiedot / kassa yhteensumma
            double cost = 0;


            /*-
            - randomi char luvut, esim tossa 0-9. jonka tulee "tilauks_":ksen jälkeen tuleva randomiluku, toki voidaan lisätä erikoismerkkejä tai aakkosia
            - lisäksi sen jälkeen lisäänty datetime, joka on pp.kk.yyyy aika. toki voidaan tehdä että päiväys ja aika.
            - mutta kun käyttäjä/asiakkas tallentaa tiedot, tulee liian pitkä tallennus tieto, siksi se on lyhyempi
                        
             */
            string chars = "0123456789";
            Random rnd = new Random();
            string name;
            do
            {

                name = string.Empty;
                while (name.Length < 7)
                {

                    name += "Tilaus_" + chars.Substring(rnd.Next(chars.Length), 1) + DateTime.Now.ToString("_yyyy_MM_dd_");
                    //tulostuu Tilaus_5_2018_10_09_
                    //eli nimi + random luku char:ilsta + päiväys (vvvv.kk.pp)

                }

                name += ".txt";

            } while (File.Exists(Path.Combine(@"C:\temp\development-team-05\123\123\bin\Debug\", name)));

            StreamWriter streamWriter = new StreamWriter(name);

            List<int> tuotteet = new List<int>();

            Console.WriteLine("Tervetuloa verkkokauppaan!".ToUpper());


            Console.WriteLine("\nOle hyvä ja anna yhteystietosi");
            streamWriter.WriteLine("Asiakkaan yhteystiedot:");

            Console.WriteLine("\nNimi:");
            nimi = Console.ReadLine();
            streamWriter.WriteLine("Nimi: " + nimi);

            Console.WriteLine("\nSähköpostiosoite:");
            sposti = Console.ReadLine();
            streamWriter.WriteLine("Sposti: " + sposti);

            Console.WriteLine("\nPuhelinnumero:");
            pnumero = Convert.ToInt32(Console.ReadLine());
            streamWriter.WriteLine("pNumero: " + pnumero);


            //lisääntyy tilauksen tiedostoon, aika milloin asiakkas on tilannut tässä esim. aika ensimmäisenä sitten pp.kk.yyyy
            /* sekä tämä DateTime koodi/rivi, jossa on oikeat ajat ja päiväykset. eli visual studio että windows:in mukaan
             * tässä kunnes käyttäjä/asiakas on tallentanut tiedot (10) ja poistunut (0)
             * jos käyttäjä/asiakkas ei tallenna tietoa(10), siirtyy suoraan poistumaan (0) tiedot ei tallennu
             * tiedot tallentuu suoraan sinne notepadiin mitä on määritetty name += ".txt"
             * 
             * mallitulostuksen ajasta & tiedostossa
             * 
             * Asiakkaan yhteystiedot:
             * Nimi: Alfa
             * Sposti: @outlook.com
             * pNUmero: 0100100
             * 17.29.30                                             (tässä on tunnit.min ja sekunnit)
             * 11.12.13                                             (päiväys pp.kk.yyyy)
             * Yhteenveto tilauksesta:
             * Summa 123
             * 
             * 1                                                    (käyttäjä/asiakkaan tilaukset)
             * 2
             * 3
             * 
             
             
             */
            
            DateTime wa = DateTime.Now;

            string Timeonly = wa.ToLongTimeString();

            streamWriter.WriteLine(Timeonly);

            //päiväys, milloin tilattu päivä
            DateTime dateAndTime = DateTime.Now;
            streamWriter.WriteLine(dateAndTime.ToString("dd/MM/yyyy"));



            Console.WriteLine("\nVoit poistua kaupasta valitsemalla numeron 0".ToUpper());
            Console.WriteLine("Voit tyhjentää ostoskorin valitsemalla numeron 9".ToUpper());
            Console.WriteLine("Voit vahvistaa tilauksen valitsemalla numeron 10".ToUpper());

            Console.WriteLine("\nVoit valita tuotteen ostoskoriin valitsemalla tuotteen numeron".ToUpper());

            do
            {              
                Console.WriteLine("\n1. Vessaharja 5$\n2. Kukkapurkki 10$\n3. Porakone 50$\n4. Imuri 100$\n5. Koira 1$\n6. Langaton kuulokkeet 20$ + ale -35% \n10. Tilauksen tallentaminen ja 0. lopettaa tämän online ostoksen");
                Console.WriteLine("____________________________________");
                numero = Convert.ToInt32(Console.ReadLine());

                switch (numero)
                {

                    case 0:
                        Console.WriteLine("Kiitos käynnistä!".ToUpper());
                        tuotteet.Clear();
                        break;
                    case 1:
                        Console.WriteLine("\nTuote numero 1. on lisätty tilaukseen");
                        tuotteet.Add(1);                       
                        cost += 5;
                        break;

                    case 2:
                        Console.WriteLine("\nTuote numero 2. on lisätty tilaukseen");
                        tuotteet.Add(2);
                        cost += 10;
                        break;
                    case 3:
                        Console.WriteLine("\nTuote numero 3. on lisätty tilaukseen");
                        tuotteet.Add(3);
                        cost += 50;
                        break;
                    case 4:
                        Console.WriteLine("\nTuote numero 4. on lisätty tilaukseen");
                        tuotteet.Add(4);
                        cost += 100;
                        break;
                    case 5:
                        Console.WriteLine("\nTuote numero 5. on lisätty tilaukseen");
                        tuotteet.Add(5);
                        cost += 1;
                        break;

                        //alennus tuote, eli esim tuotteesta * sen prosenttin ale
                        //se lisääntyy suoraan automaatisesti muiden tuoteiden kanssa yhteen
                        //jos käyttäjä/asiakkas haluu (6) niin se laskee ton 27*0,35 ensin => 9.45
                        //sitten toi alennus tuote + muiden tuoteiden kanssa yhteen
                        //toki se laskee vielä ton alv prosenttin
                    case 6:
                        Console.WriteLine("\nTuote numero 6. on lisätty tilaukseen");
                        tuotteet.Add(6);
                        cost += 27 *0.35;
                        break;
                    case 9:
                        Console.WriteLine("Ostoskori tyhjennetty!");
                        tuotteet.Clear();
                        cost = 0;
                        break;

                    case 10:
                        Console.WriteLine("Tilaus vahvistettu! Voit poistua kaupasta valitsemalla numeron 0");
                        Console.WriteLine("Tervetuloa uudelleen!");
                        using (streamWriter)
                        {
                            streamWriter.WriteLine("Yhteenveto tilauksesta:");
                           
                            streamWriter.WriteLine("Summa " + cost);            //summa ja alv vero lisääntyy tiedostossa jossa näkyy maksu kokonais summan
                            streamWriter.WriteLine("Alv vero " +0.24 * cost);   //että alv vero kaikkista tuotteesta mitä siinä on, eli se suuruus


                            //joka ikinen tuote, lisääntyy tiedostoon, numeroina
                            foreach (int tuote in tuotteet)
                            {
                                streamWriter.WriteLine(tuote);
                               
                                
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("\nValitse jokin tuote, ole hyvä");
                        break;
                }

                foreach (int tuote in tuotteet)
                {
                    Console.WriteLine("Ostoskorissa on seuraavat tuotteet: " + tuote);
                }

                if (cost != 0)
                {
                    Console.WriteLine("Yhteensä {0} euroa.", cost);
                    Console.WriteLine("Alv: " +0.24 * cost);

                }
            } while (numero != 0);

                    /*alv vero eli 24% tuotteesta, eli toi laskee kaikki käyttäjän/asiakkaan tuotteesta 0,24 * tuotteet
                     *siis tuotteen yhteensä, kaikken kaikkiaa sitten kertoo ton prosenttin
                     *sekä se tulostaa sen prosentti suuruuden, paljon se onkaan
                     * 
                     * malli tuotteesta::
                     * 
                     * 1     (vessaharja)    5€
                     * 2     (Kukkapurkki)   10€
                     * 4     (Imuri)         100€
                     * 3     (Porakone)      50€
                     * ___________________________
                     * yhteensä              165€
                     * alv:                  39,60€


                     * malli ale tuotteesta::
                     * 
                     * 4     (Imuri)                                100€
                     * 3     (Porakone)                             50€ 
                     * 6     (kuulokkeet + ale) 27 * 0,35%          9,45€   (jos haluttaan desimaaliksi, palaa alkuu jossa lukee double = cost;
                     * ____________________________________________________
                     * yhteensä                                     159,45€
                     * alv:                                         38,268€ (ei ole pakko olla mukana toi alv vero & myös viittaa double = cost; 
                     *                                                       koska se sisältyy siihen)
                 */

        }
    }
}
