using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "John ";
            Console.WriteLine($"Hello {name}!");
            Console.WriteLine("Greeding!! ");

            Console.Write("Hello, {0}!", Console.ReadLine());
            Console.ReadLine(); // pysähtyy tähän
        }
    }
}

----------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your firstname?"); // cw <Tab<>Tab>
            var firstname = Console.ReadLine();
            Console.WriteLine("And Lastname?");
            string lastname = Console.ReadLine();

            Console.WriteLine("Hello " + firstname + "," + lastname + "!");
            Console.ReadLine(); //pysähtyy tähän
           
        }
    }
}
____________________________________________________
Laske1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna ikäsi vuosina");
            var num = Console.ReadLine(); //lukee vain käyttäjän syöttämät luvut, jos lukee kirjainta tai erikoismerkkiä muuttuu "error"
                                                         //Console.Readline vähä nii kui scanf että käyttäjä syöttää jotakin
            int luku = int.Parse(num);
            luku = luku + 5; //syötät iän niin alhaalla se laskee sen luvun
            Console.WriteLine("Viiden vuoden päästä olet " +luku+ "v");
        }
    }
}
_______________________________________________
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna eka luku");
            var num1 = Console.ReadLine();
            int luku1 = int.Parse(num1);

            Console.WriteLine("Anna toka luku");
            var num2 = Console.ReadLine();
            int luku2 = int.Parse(num2);


            int luku3;
            luku3 = luku1 + luku2;
            Console.WriteLine("Summa " + luku3);

            int luku4;
            luku4 = luku1 - luku2;
            Console.WriteLine("Erotus " +luku4);

            int luku5;
            luku5 = luku1 * luku2;
            Console.WriteLine("Tuloa" + luku5);

  
            Console.ReadLine();
 
        }
    }
}

__________________________________________
keskiarvo

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna eka luku");
            var num = Console.ReadLine();
            int luku = int.Parse(num);

            Console.WriteLine("Anna toka luku");
            var num2 = Console.ReadLine();
            int luku2 = int.Parse(num2);

            Console.WriteLine("Anna kolmas luku");
            var num3 = Console.ReadLine();
            int luku3 = int.Parse(num3);

           double summa = (luku + luku2 + luku3) / 3.0; //laskee summan
            //jos pelkä 3 niin kokonaisluku, mutta 3.0 niin desimaaliluku


            Console.WriteLine("Keskiarvo on " + summa);
            Console.ReadLine();

        }
    }
}
________________________
keskiarvo (if & else)
static void Main(string[] args)
        {
            Console.WriteLine("Anna eka luku");
            var num = Console.ReadLine();
            int luku = int.Parse(num);

            Console.WriteLine("Anna toka luku");
            var num2 = Console.ReadLine();
            int luku2 = int.Parse(num2);

            Console.WriteLine("Anna kolmas luku");
            var num3 = Console.ReadLine();
            int luku3 = int.Parse(num3);

            double summa = (luku + luku2 + luku3) / 3.0; //laskee summan
            //jos pelkä 3 niin kokonaisluku, mutta 3.0 niin desimaaliluku

            if (summa < 2)
            {
                Console.WriteLine("Tsemppii");

            }
            else
            {

                Console.WriteLine("Keskiarvo on " + summa);

            }

        }

___________________________________
tulostaa 1-10 rivit

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 0; i < 11; i++) // for<tab><tab>
            {
               
                Console.WriteLine(i);
            }
            
        }
    }
}
___________________________

static void Main(string[] args)
        {
            int i;
            //tulostaa 1-10 tai
            // tulostaa luvut 90-70, kahden välein
            // i++ tarkoittaa i=i+1 (myös i+=1)
            for (i = 0; i < 11; i++) // for<tab><tab>
            {
               
                Console.WriteLine(i);
            }

            for(i = 90; i > 68; i-=2)
            {
                Console.WriteLine(i);
            }
}
________________________________________
keskiarvo laskeminen, kysyy käyttäjältä monta lukua syöttää

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0, avg = 0;
            Console.Write("How many numbers you want to enter?");
            int n = Int32.Parse(Console.ReadLine());
            double[] numbers = new double[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Number {0}: ", i + 1);
                numbers[i] = Convert.ToDouble(Console.ReadLine());
                sum += numbers[i];
            }
            avg = sum / numbers.Length;

            Console.WriteLine("The Average is : " + avg);

            Console.ReadLine();
        }
    }
}
_________________________________
