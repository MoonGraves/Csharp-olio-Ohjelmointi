using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");

    bool backTop = true;

    while(backTop)
    {

      string[] names = {"1","2","3","4"};
      Console.WriteLine("Type any number");

      string consoleRead = Console.ReadLine();

      int x = Array.IndexOf(names, consoleRead);
      if( x > -1)
      {
        Console.WriteLine("");
        Console.WriteLine("It's availeble");
      }
      else
      {
        Console.WriteLine("");
        Console.WriteLine("Try again");
      }

    }
    backTop = false;

  }
}
