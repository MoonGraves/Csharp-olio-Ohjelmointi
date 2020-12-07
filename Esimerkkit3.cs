"for loop" vähä nii kuin toistorakenne, joka toistaa annettua koodia, kunnes annettua toistoehto ei enää evaluoida todeksi.

esim:

static void Main()
    {
        //
        // Prints every tenth number from 0 to 200.
        // Includes the first iteration.
        //
        for (int i = 0; i < 200; i++)
        {
            if ((i % 10) == 0)
            {
                Console.WriteLine(i);
            }
        }

tässä se tulostaisi 0, 10, 20 ja jne päättyy 190 lukuun asti, koska (i % 10) joka kymmennes luku, jos halutaisi oikeasti tasan 200, niin pitää olla i < 210; 

esim. jos käyttäjä näppytää kirjaimia, niin lukee monta kirjainta käyttäjä on syöttänyt, sekä ei laske väliä vaikka olisi kokonainen lause / ilmaisu. jos haluu lopettaa, niin lukee käyttäjä syöttää vain "exit"

while (true) // Loop indefinitely
        {
            Console.WriteLine("Enter input:"); // Prompt
            string line = Console.ReadLine(); // Get string from user
            if (line == "exit") // Check string
            {
                break;
            }
            Console.Write("You typed "); // Report output
            Console.Write(line.Length);
            Console.WriteLine(" character(s)");
        }

______________________________________________________________

using System;
using System.Collections.Generic;
using System.Globalization;

public class Example
{
   public static void Main()
   {
    Console.WriteLine("Welcome");

     string nimi;
     string sposti;
     int pnumero;
     string osoite;


    Console.WriteLine("\nOle hyvä ja annayhteystietosi");
    Console.WriteLine("\nNimi: ");
    nimi = Console.ReadLine();
    
    Console.WriteLine("\nSähköpostiosoite:");
    sposti = Console.ReadLine();

    Console.WriteLine("\nOsoite");
    osoite = Console.ReadLine();

    Console.WriteLine("\nPuhelinnumero:");
    pnumero = Convert.ToInt32(Console.ReadLine());

    
    Console.WriteLine("\nYhteenveto");
    Console.Write("\nNimi {0} ", nimi) ;
    Console.Write("\nOsoite {0}", osoite ) ;
    Console.Write("\nSposti on {0}", sposti) ;
    Console.Write("\nPuhelin numero {0} ", pnumero);
   }
}
