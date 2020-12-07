using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");

    string nimi;
    nimi = Console.ReadLine();
    Console.WriteLine("Viesti & enintään 5 riviä, kiitos!!! \nOhje!: enintään 5-riviä & 5-enteriä jos ei ole murheita/kommentia/palautetta, kiitos!!\n");
    
    //tämä string rivi alkaen että käyttäjä kirjoittaa esim sen 5 kokonais riviä,  
   //ei vaikuta että käyttäjään kirjoittaisi yli tuhat sanaa, kunnes käyttäjä lyöö 5 enteriä, niin se lopettaa sen
    string[] names = new string[5];
    for (int i = 0; i < 5; i++)
    {
    //names[i] = Console.ReadLine();
    }
    

   //palauteen tiedoston nimi, mukaan tulee ekaks kun käyttäjä lyöö joku satunais nimen
   string chars2 = "0123456789";
   Random SMS = new Random();

   StreamWriter SW = new StreamWriter(@"Palaute_" + chars2.Substring(SMS.Next(chars2.Length), 1) + "_" +nimi + ".txt");

    //edellisessä rivissä, for-koodi pätkässä lukaisee ne käyttäjän kirjoittaman tekstit, ja tallentaa ne mukaan .txt tiedostoon
    for (int i = 0; i < 5; i++)
    {                         
     SW.WriteLine(names[i]);
    }

    SW.Close();
  }
}
