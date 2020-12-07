ajat, nämä tulostuu erikseen eli aika ja pp.kk.yyyy


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication29
{
    class Program
    {
        static void Main(string[] args)
        {

          Console.WriteLine("Tänään");  
            DateTime wa = DateTime.Now;

            string Timeonly = wa.ToLongTimeString();

            Console.WriteLine(Timeonly);


            DateTime dateAndTime = DateTime.Now;
            Console.WriteLine(dateAndTime.ToString("dd/MM/yyyy"));
        }
    }
}
