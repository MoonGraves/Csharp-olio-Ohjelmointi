using System;

class MainClass {
  public static void Main (string[] args) {

        string comparison;
         Console.WriteLine("Anna kaksi lukua:");
         double x = Convert.ToDouble(Console.ReadLine());
         double y = Convert.ToDouble(Console.ReadLine());

         if (x < y)
            comparison = "pienempi kuin";
         else
         {
            if (x == y)
               comparison = "yhtä suuri kuin";
            else
               comparison = "suurempi kuin";
         }
         Console.WriteLine("{0} on {2} {1}", x, y,comparison);
    
    }
}
