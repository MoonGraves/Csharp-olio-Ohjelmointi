using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Class2    //Osa
    {
        //tee tästä property
        int luku; //jotain sisältöä

        public int Luku { get => luku; set => luku = value; }


        //Tulosta
        public string Tulosta()
        {
            return "O: " +Luku.ToString();
        }
    }
}
