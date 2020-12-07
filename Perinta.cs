


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonLibrary;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonPlus person1 = new PersonPlus();
            person1.Name = "Ethan";
            person1.Age = 20;

            PersonPlus person2 = new PersonPlus();
            person2.Name = "Jenny";
            person2.Age = 22;

            //lisäät lista.add(persn jokuluku mitä ylemmässä rivissä lukekaan, nii tulostaa sen nimen)
            Class1 lista = new Class1();
            lista.Add(person1);
            lista.Add(person2);

            Console.WriteLine(lista.GetAt(0).Tulosta());

            //tää viittaa public override stringiin, koska String rString siihen tulostavaan kommentiin, eli consolewriteline
            Console.WriteLine(lista.ToString());
            
        }
    }
}



luokka class1.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonLibrary;

namespace ConsoleApp34
{
    class Class1 : PersonList
    {
        public override void Add(PersonPlus person)
        {
            //jos henkilön ikä on suurempi tai yht suuri kuin 18, mutta jos henkilö on 18 niin se null:aa sen
            if (person.Age >= 18)
            {
                base.Add(person);
            }

        }

        public override PersonPlus GetAt(int index)
        {   
            //base.getat(index) palauttaa personplus luokan olion
            //index-muuttuja sisältää kokonaislukvun, joka kertoo monesko listan olioista hetaan
            if(base.GetAt(index).Age >= 20)
            {
                return base.GetAt(index);
            }
            else return null; //jos ikä on alle, palautetaan null
        }

        public override string ToString()
        {
            String rString = "Tappolistalta löytyy olevia henkilöitä: \n";
            foreach(PersonPlus person in this.personList)
            {
                rString += person.Tulosta() + "\n";
            }

            return rString;
        }

    }
}
