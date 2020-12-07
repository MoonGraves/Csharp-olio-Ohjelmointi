 Ohjelma, joka kysyy "Montako lukua", kysyy luvut ("Anna luku") ja laskee niistä keskiarvonsa
 Kysyy "Yhteen- vai vähennyslasku (+/-)", kysyy 2 lukua, laskee valitun toiminnan ja tulosta
 
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
            int m, i, sum = 0, avg = 0; //kysyy monta lukua käyttäjä syöttää
            Console.WriteLine("Monta lukua? "); 

            m = int.Parse(Console.ReadLine());
            int[] a = new int[m];

            Console.WriteLine("Anna luvut "); //käyttäjä antaa luvut
            for (i = 0; i < m; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < m; i++)
            {
                sum += a[i];
            }
            avg = sum / m; //keskiarvo avg

            if (avg < 3) //jos keskiarvo on pienempi kuin 3
            {
                Console.WriteLine("You fail");
            }
            else
            {
                Console.WriteLine("Keskiarvo on {0} ", avg);
            }

            Console.ReadLine();
        }
    }
}


____________________________________

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
            int a, b, ch;

            start: //Kysyy ekaks vaihtoehtosi
            Console.WriteLine("Valitse vaihtoehtosi : Summa:0  Erotus:1  Kerto :2 :");

            ch = Convert.ToInt32(Console.ReadLine());

            //Käyttäjä antaa luvut 
            Console.WriteLine("Eka luku a:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Toinen luku b:");
            b = Convert.ToInt32(Console.ReadLine());

            switch (ch)
            {
                case 0:
                    Console.WriteLine("Yhteenlasku :{0}", a + b);
                    break;

                case 1:
                    Console.WriteLine("Erotus :{0}", a - b);
                    break;

                case 2:
                    Console.WriteLine("Kertolasku :{0}", a * b);
                    break;

                default:
                    Console.WriteLine("Invalid choice ");
                    ch = 0;
                    goto start;
            }
        }
    }
}
