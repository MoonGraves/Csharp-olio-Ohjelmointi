using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        int numero;

        public int Numero
        {
            get => numero + 1;
            set => numero = value;
        }
          public string Tulosta()
        {
            return $"it works Numero={Numero}";
        }
    }
}
