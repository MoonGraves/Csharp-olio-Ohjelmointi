using System;

class MainClass {
  public static void Main (string[] args) {
	Console.WriteLine("Anna binääriluvut 11001101 sekä 01010111:");
	  
	int ekaNum, tokaNum, resulti;  
	ekaNum = Console.ReadLine();
	tokaNum = Console.ReadLine();
	resulti = ekaNum | tokaNum;
	  
	  
	Console.WriteLine("{0} | {1} = {2}", ekaNum, tokaNum, resulti);
  
  }
}
