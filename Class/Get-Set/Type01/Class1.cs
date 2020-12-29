using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Class1
    {
        string Name;
        int Age;

        public string GetName()
        {
            return Name;
        }

        public void SetName(string n)
        {
            Name = n;
        }

        public int GetAge()
        {
            return Age;
        }

        public void SetAge(int newAge)
        {
            Age = newAge;
        }



        //tehtv. tee samat age:lle, käytä set/get- metodeista main:ssa
        
        public string HaeTekstinä()
        {
            return $"{Name}, {Age}v";
        }

    }
}
