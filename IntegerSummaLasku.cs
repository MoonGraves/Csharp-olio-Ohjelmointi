using System;
using System.IO;

class MainClass {
  public static void Main (string[] args) {
   Console.WriteLine ("Hello World");

  Console.WriteLine("Enter five type integer ");

  int integerSum = 0;

  for (int i = 0; i < 5; i++)
  {
    Console.WriteLine("Type Integer {0}", (i + 1 ));
    string rawInput = Console.ReadLine();

    int IntegerInput;
    bool isInteger = int.TryParse(rawInput, out IntegerInput);

  //Lukaisee käyttäjän näppytyksen jos yhtäkkiä näppyttää kirjaimia
  //hyväksyy vain luku koska int.trypase(pälä pälä)
    if(isInteger == false)
    {
      Console.WriteLine("This is not a vlid integer. Please enter a valid integer now");
      i--;
      continue;
    }
    else
    {
      integerSum += IntegerInput;
    }

  }

  Console.WriteLine("Results : "+ integerSum);    
    
  }
}
