using System;

class MainClass {
  public static void Main (string[] args) {
        double DblSumTotal = 0;
        double LIMIT = 0;

        //Console.WriteLine("Anna luku");
        do 
        {
          Console.WriteLine("Anna luku");
            DblSumTotal = DblSumTotal + (Convert.ToDouble(Console.ReadLine()));
            LIMIT = LIMIT + 1;
        } while (LIMIT < 5);

        //Output total
        Console.WriteLine("Kierroksia 5, lopetetaan ohjelma. ");


  }
}
