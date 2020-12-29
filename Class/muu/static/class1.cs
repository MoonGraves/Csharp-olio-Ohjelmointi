using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Class1
    {
        int luku;
        static int luokanArvo = 3;
        //konstruktori
        public Class1(int luku)
        {
            this.luku = luku;
        }
        public static int Laske(int a, int b)
        {
            return a + b;
        }

        public string Tulosta()
        {
            return luku.ToString();
        }

        public static string TietojaLuokasta()
        {
            return "OmaLuokka " +luokanArvo; 
        }
    }
}
