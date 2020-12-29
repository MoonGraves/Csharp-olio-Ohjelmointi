using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassLibrary1.Class1 olio = new ClassLibrary1.Class1();
            olio.Numero = 99;
            Console.WriteLine(olio.Tulosta());
        }
    }
}
