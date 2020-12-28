using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    
    //char fileNimi;
    string fileNimi;

    string[] fileArray = Directory.GetFiles(@"Kansiot", "*.txt", SearchOption.AllDirectories);
    Console.WriteLine("Kansiosta löytyi tällaisia kuin:: \n");
    
    //Tulostettaan haluamat Directory-kansio juttut
    for (int i = 0; i < fileArray.Length; i++)
    {
    
      Console.WriteLine(fileArray[i]+ "\n");

    }//
    //////////////////

    Class1 muuttuja = new Class1();
    muuttuja.Tervehdi();

    Console.WriteLine("___________________" + "\n");
    System.Threading.Thread.Sleep(2500); //millisekuntti eli 1s >> tuhatta, 2s >> 20000
    
    Start:
    Console.WriteLine("Avataan se tiedoston nimi: \n Tiedostoa löytyy mm:: ");

      fileNimi = Console.ReadLine();
      
        switch (fileNimi)
        {
          case "a":
          case "file":
          
         string line = "";
         using (StreamReader sr = new StreamReader("Kansiot/Directory/file.txt")) 
         {
            while ((line = sr.ReadLine()) != null) 
            {
               Console.WriteLine(line);
            }
         }
         break;
         ///////////////

         case "b":
         case "file2":
         using (StreamReader sr = new StreamReader("Kansiot/Directory/file2.txt")) 
         {
            while ((line = sr.ReadLine()) != null) 
            {
               Console.WriteLine("\n" + line);
            }
         }
         break;
         ///////////////

        case "c":
        case "LoremIpsum":
        //case "loremipsum":
        using (StreamReader sr = new StreamReader("Kansiot/Folder2/LoremIpsum.txt")) 
         {
            while ((line = sr.ReadLine()) != null) 
            {
               Console.WriteLine("\n" + line);
            }
         }
         break;
         //////////////

         ////
         default:
         Console.WriteLine("Ei löydy sellaista");
         break;
         
        } //switch case {} END
        System.Threading.Thread.Sleep(1250);

    Decide:
    Console.WriteLine("\n Etsitäänkö uuestaan? y/n");
    string UserDecide = Console.ReadLine();

      switch (UserDecide.ToUpper())
      {
        case "Y":
        if (UserDecide.Equals ("y"))
          goto Start;
        else
          goto Start;

        case "N":
        if (UserDecide.Equals("n"))
          break;
        else
          break;

        default:
          Console.WriteLine("Valintasi oli {0}, is invalid", UserDecide);
          goto Decide;
      }
      while (UserDecide == "Y");
      
    Console.WriteLine(muuttuja.MuuTervehdys()); //Lukee class1.cs

  }
}
