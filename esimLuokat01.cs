program cs.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 kok = new Class1();
            Class2 osa = new Class2();
            osa.Luku = 42;
            kok.LisääOsa(osa);

            Class2 vOsa = new Class2();
            vOsa.Luku = 21;
            kok.LisääVaraosa(vOsa);

            //tulostaa
            Console.WriteLine(  osa.Tulosta());
            Console.WriteLine(  kok.Tulosta());
            Console.WriteLine( vOsa.Tulosta());

        }
    }
}


luokka class1 .cs 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Class1    //Kokonaisuus
    {
        Class2 osa;
        Class2 varaosa;


        //Lisää osa
        public void LisääOsa(Class2 osa)
        {
            this.osa = osa;
        }

        public void LisääVaraosa(Class2 osa)
        {
            this.varaosa = osa;
        }

        // Tulosta
        public string Tulosta()
        {
            return "K: " +osa.Tulosta() +"V: " +varaosa.Tulosta();
        }
    }
}


luokka class2.cs 

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
