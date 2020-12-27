using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");

    double TotalCoffeeCost = 0;

    Start:
      Console.WriteLine("Please enter your selection: Coffee sizes: 1=small 2=medium 3=large 4=HotDog");
      int UserChoice = int.Parse(Console.ReadLine());

      switch (UserChoice)
      {
        case 1:
        //case "small":
        TotalCoffeeCost += 7.5;
        break;

        case 2:
        //case "medium":
        TotalCoffeeCost += 12.20;
        //goto case "1";
        break;
        
        case 3:
        //case "large":
        TotalCoffeeCost += 20.85;
        //goto case "1";
        break;

        case 4:
        TotalCoffeeCost += 13 * 0.30;
        break;

        default:
        Console.WriteLine("Invalid selection. Please select 1, 2, or 3.");
        goto Start;
      }

      Decide:
      Console.WriteLine("More coffee, y/n");
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
          Console.WriteLine("Your choice {0}, is invalid, try again", UserDecide);
          goto Decide;
      }
      while (UserDecide == "Y");

      Console.WriteLine("Thank u, come again");
      Console.WriteLine("Bill acount = {0}", TotalCoffeeCost);

  }
}
