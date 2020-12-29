using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Pelaaja
    {
        string alias;
        int pisteet;

        //ctor <tab><tab> a
        public Pelaaja()
        {

        }

        public string Alias { get => alias; set => alias = value; }
        public int Pisteet { get => pisteet; set => pisteet = value; }
    }
}
