using System;

class MainClass {
  public static void Main (string[] args) {

        float x, y;

        Console.WriteLine("Anna kaksi kokonaislukua:");
        x = Convert.ToInt64(Console.ReadLine());
        y = Convert.ToInt64(Console.ReadLine());

        Console.WriteLine("Lukujen jakojäännös on: {2}", x, y, x%y);
    
    }
}
