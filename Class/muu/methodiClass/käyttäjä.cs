using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testi_1
{
    class Käyttäjä
    {
        Lisätieto lisätieto;

        // TODO: tähän tarvitaan metodi, jolla lisätieto muuttujaa asetetaan arvo

        public string Tulosta()
        {
            return lisätieto.Tulosta();
        }

        internal void AsetaLisätietoa(Lisätieto lisätieto)
        {
            this.lisätieto = lisätieto;
        }
    }
}
