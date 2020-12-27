using System;

class MainClass {
  public static void Main (string[] args) {

    string UserChoice = string.Empty;
    do
    {
      Console.WriteLine("Anna parillinen luku");
      int UserTarget = int.Parse(Console.ReadLine());

      int Start = 0;

      while ( Start <= UserTarget)
      {
        Console.WriteLine(Start + " ");
        Start = Start + 2;
      }
      
      do
      {
        Console.WriteLine("\nJatketaanko uuestaan Yes tai No?");
        
        var result = Console.ReadLine();
        
        if (result != null)
            UserChoice = result.ToUpper();

        if (UserChoice != "YES" && UserChoice != "NO")
          {
           Console.WriteLine("Invaild Choice, Please say Yes or No");
          }
  
         } while (UserChoice != "YES" && UserChoice != "NO");
      } while (UserChoice == "YES");
      Console.WriteLine("End");
  }
}
