
using System;
class HelloWorld {
  static void Main() {
    
     string answer;
        int runCount= 0;

        do
        {
          ++runCount;
          Console.WriteLine("Name:");
          string name = Console.ReadLine();

          Console.WriteLine("Age:");
          int age = int.Parse(Console.ReadLine());

          if(age >= 0 && age <= 10)
          {
              Console.WriteLine("Child");
          }
          else if(age <= 20)
          {
              Console.WriteLine("Young adult");
          }
          else if(age <= 65)
          {
              Console.WriteLine("Adult");
          }

          Console.WriteLine("Greedings, {0} , your age is a {1} yo", name, age);

          Console.WriteLine("Try again? J/N");
          answer = Console.ReadLine();
        }
        while(runCount < 3 && answer == "N");
        
  }
}
