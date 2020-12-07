käyttäjä näppytää alle tai tasan 6 riville jotakin lukua, ei väliä onko yksi, vai kemmennes vai tuhannes
sekä q kirjain, nii se tallentuu. sekä joka kerta uusi tiedosto, niin se tallentaa vanhan tiedoston päälle eli vanha tiedosto poistuu

using System;
using System.IO;

class MainClass 
{
  public static void Main (string[] args) 
  {
    int[] array = new int[6];
    string file= "file1.txt";
    printToFile(array, file);
    int i =0;
    string response;
    Console.Write("Enter a number:");
    while((response =Console.ReadLine()) !="q")
    {
      try
      {
        array[i]= int.Parse(response);
        i++;
      }
      catch(FormatException)
      {
        Console.WriteLine("Um, I said number....:(");
      }
      catch(IndexOutOfRangeException)
      {
        break;
      }
      Console.Write("Enter a number:");
    }
    printToFile(array, file);
    Console.ReadKey();
  }
  static void printToFile(int[] arr, string fileName)
  {
    StreamWriter writer = new StreamWriter(@fileName);//could put this in using parameters
    using(writer)//opens and closes file
    {
      for(int i=0; i<arr.Length;i++)
      {
        writer.WriteLine(arr[i]);
      }
      //DirectoryNotFoundException
      //IOException
      //UnauthorizedAccessException
    }
  }
}
