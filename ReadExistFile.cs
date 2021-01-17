using System;
using System.IO;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");

    //Read exist file.txt
    string fpath = "file.txt";

    StreamReader sr = new StreamReader(fpath);
    try
    {
      string txt;
      while((txt = sr.ReadLine()) !=null)
      {
        //Input the file inside all lines 
        Console.WriteLine(txt);
      }
    }

    catch(Exception ex)
    {
      Console.WriteLine("Exception: {0}", ex.Message);
    }

    finally
    {
      if (sr !=null)
      {
        sr.Close();
      }
    }    

  }
}
