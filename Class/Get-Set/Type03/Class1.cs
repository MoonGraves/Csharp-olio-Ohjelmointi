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
