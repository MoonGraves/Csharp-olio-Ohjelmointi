using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
           /*int person ikä = x;
           *string person name = y;
           * int toisen ikä = x;
           * int toisen nimi = y;
           * 
           */

            Class1 person = new Class1();
            person.SetName("tantta");
            person.SetAge(21);

            Class1 toinen = new Class1();
            toinen.SetName("TY");
            toinen.SetAge(33);

            Tulosta(person); //tai Tulosta(toinen);
            Tulosta(toinen);


        }

        private static void Tulosta(Class1 person)
        {
            Console.WriteLine(person.HaeTekstinä());

            //Console.WriteLine($"{person.GetName()}, {person.GetAge()}v");
            //console.writeline(person.Name+", "+person.age+"v");
        
        }
    }
}
