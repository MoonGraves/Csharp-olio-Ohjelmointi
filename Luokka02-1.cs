program.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Part> parts = new List<Part>();

            //Console.WriteLine("\nCapacity: {0}", parts.Capacity);
            //capacity asettaa tai saada kokonaisuuden, jonka sisäisen tietorakenne voi olla, muuttumatta kokoa?

            parts.Add(new Part() { PartName = "Shift",      PartId = 1 });
            parts.Add(new Part() { PartName = "Del",        PartId = 2 });
            parts.Add(new Part() { PartName = "Alt",        PartId = 3 });
            parts.Add(new Part() { PartName = "Scroll",     PartId = 4 });
            parts.Add(new Part() { PartName = "Emolevy",    PartId = 5 });
            parts.Add(new Part() { PartName = "Ctrl ",      PartId = 6 });
            parts.Add(new Part() { PartName = "RocknRoll",  PartId = 7 });

            List<Ope> ope = new List<Ope>();
            ope.Add(new Ope()   { OpeName = "Burgeri",      OpeId = 1  });
            ope.Add(new Ope()   { OpeName = "Celcius",      OpeId = 2 });

            //parts.Add(new Part() {PartName = "Beech", PartId = 1 });

            //Tulostuksessa tulostaa part.Add(new Part() pälä pölö listan, elikkä
            //PartName = jotakin, partId mones tuote ja näin
            //koska (luokka capacity.cs) lukee sen määritettyn x-määrän
            //jota tulostaa

            Console.WriteLine();
            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }

            Console.WriteLine();
            foreach (Ope aOpe in ope)
            {
                Console.WriteLine(aOpe);
            }

            //Console.WriteLine("\nCapacity: {0}", parts.Capacity);
            
            Console.WriteLine("\nTuoteita & Varasto: {0}", parts.Count);
            Console.WriteLine("Opettajia / Lehtori: {0}", ope.Count);
            /*tulostuu vain oma luokkan listan x määrä, mitä listassa lukee
             * että opettajien määrä             
             */


            parts.TrimExcess();
            Console.WriteLine("\nTappolistalla()");
            //Console.WriteLine("Capacity: {0}", parts.Capacity);
            Console.WriteLine("Tuoteita & Varastos: {0}", parts.Count);
            //varmennus uusi rivi, että erikseen tunnistaa että tietää mitä x määriä
            //on mitäkin mihin varten


            //Console.WriteLine("\nTuoteen: {0}" + " Opettajia", ope.Count);
            ope.TrimExcess();
            Console.WriteLine("\nOpettajia()");
            Console.WriteLine("Henkilöstö: {0}", ope.Count);
            //yhteenveto, että uusi rivi, jossa tunnistaa oman määrän mitäkin on 

            /*
            parts.Clear();
            Console.WriteLine("\nClear()");
            Console.WriteLine("Capacity: {0}", parts.Capacity);
            Console.WriteLine("Count: {0}", parts.Count);
            */
        }
    }
}


luokka capacity.cs


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*IEquatable:: rajapintaan tulevat vertailuksi peläkän Equals-metodin
 * pohjatoteutuksen perusteella, mikä pahmmillaan tarkoittaa pelkän
 * objektista generoidun tarkistearvon vertailua. Jossain tilanteissa
 * tämä saattaa olla haluttu toimintamalli, toisissa taas tärkemäpää
 * olisi tietää vastaako objekti sisäiseltä
 * tilaaltaan vertailtava objektia.
 
     */

public class Part : IEquatable<Part>
{
    public string PartName
    {
        get;
        set;
    }

    public int PartId
    {
        get;
        set;
    }

    public override string ToString()
    {
        return "ID: " + PartId + "  Name: " + PartName;
    }

    public override bool Equals(object obj)
    {
        if (obj == null) return false;
        Part objAsPart = obj as Part;
        if (objAsPart == null) return false;
        else return Equals(objAsPart);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
    public bool Equals(Part other)
    {
        if (other == null) return false;
        return (this.PartId.Equals(other.PartId));
    }
    // Should also override == and != operators.

}


luokka teacheri.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Ope : IEquatable<Ope>
{
    public string OpeName
    {
        get;
        set;
    }

    public int OpeId
    {
        get;
        set;
    }
    public override string ToString()
    {
        return "ID: " + OpeId + "   Nimi: " + OpeName;
    }
    public override bool Equals(object obj)
    {
        if (obj == null) return false;
        Ope objAsOpe = obj as Ope;

        if (objAsOpe == null)
            return false;
        else return Equals(objAsOpe);

    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
    public bool Equals(Ope other)
    {
        if (other == null) return false;
        return (this.OpeId.Equals(other.OpeId));
    }
}
