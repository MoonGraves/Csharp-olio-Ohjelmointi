using System;

class MainClass {
  public static void Main (string[] args) {
    
    double summa = 0;

do
{
//Console.WriteLine("Summa: {0}", summa);
Console.Write("Anna luku: ");
summa = summa + double.Parse(Console.ReadLine());
Console.WriteLine("{0}", summa);
} while (summa <= 100);

Console.WriteLine("Raja saavutettu.");


  }
}
