using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static string ohje = "0.Lopetus\n1.Toiminto\n2.Jatka\n3.Jatkuu";

        static void Main(string[] args)
        {
            Console.WriteLine(ohje);
            string komento = Console.ReadLine();
            while (!komento.StartsWith("0 EXIT"))   // ! tarkoittaa NOT
            {
                switch (komento)
                {
                    case "1":  //jos kommento == "1"
                        Console.WriteLine("Valitsit komennon 1 " +Environment.CommandLine);
                        break;
                    case "2": //+Environment.GetLogicalDrives()[0])
                        Console.WriteLine("Valitsit kommennon 2 " +Environment.UserName);
                        break;      //lopeta switch
                    case "3":
                        Console.WriteLine("Valitsit kommennon 3 " +Environment.UserDomainName);
                        break;
                    default:        // (else=)kaikissa muissa tapauksissa
                        break;
                }
                Console.WriteLine(ohje);
                komento = Console.ReadLine();
            }
        }
    }
}

luokka class cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    public class Class1
    {
        int koodi = 1234;

        public Class1()
        {

        }

        public override string ToString()
        {

            return koodi.ToString();
        }
        }
}
