using System;

class MainClass {
  public static void Main (string[] args) {
    int[] numbers;
numbers = new int[5];
Console.WriteLine("Anna viisi kokonaislukua: ");
numbers[0] = Int32.Parse(Console.ReadLine());
numbers[1] = Int32.Parse(Console.ReadLine());
numbers[2] = Int32.Parse(Console.ReadLine());
numbers[3] = Int32.Parse(Console.ReadLine());
numbers[4] = Int32.Parse(Console.ReadLine());
int sum = 0;

foreach (int x in numbers) 
{
   sum += x;
}

int aver = sum / numbers.Length;  
Console.WriteLine("keskiarvo: {0}",aver);


  }
}
