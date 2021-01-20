using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Aamuja!! ");

    string path = @"list.txt";
    int count;

        Console.WriteLine("Ei ole rajoitusta monta sanaa tulee olemaan \n Tähän alle kirjoitettaan haluamisi teksti:: \n ");

        //string appendText = "This is extra text" + Environment.NewLine;
        string appendText = Console.ReadLine() + Environment.NewLine;
        File.AppendAllText(path, appendText, Encoding.UTF8);

        // Open the file to read from.
        string[] readText = File.ReadAllLines(path, Encoding.UTF8);
        foreach (string s in readText)
        {
            Console.WriteLine(s);
        }

        Console.WriteLine("////////////////////////////////");
        Console.Clear();
        Thread.Sleep(2500); //will sleep for 2.5 sec

        //Lukaisee koko file tiedoston monta riviä siellä oikein sisällä on kokonaisuudessa ja sitä voidaan tulostaa edelliset asiakirjat mitä siel onkaan
        using (StreamReader sr = File.OpenText(path))
        {
          string s = "";
          count=0;
				  Console.WriteLine("Uusi asiakirja & mitä nyt lisätty: ");
          
          while ((s = sr.ReadLine()) != null)
          {
            Console.WriteLine(s);
            count++;
          }
            Console.WriteLine("");
        }
        //tulostaa monta riviä siel on kokonaisuudessaan + uusi teksti/asia
        Console.Write("The number of lines in  the file {0} is : {1} \n\n",path,count);     

  }
}
