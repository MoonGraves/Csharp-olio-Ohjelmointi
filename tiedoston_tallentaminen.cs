using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
 
namespace StreamWriter_VariableData
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"D:\csharpfile.txt";
            //avaa windows c, sitten johonkin kansioon sinne asti niin kopioi sen sivuston
            //esim c:/user/it16 ja jne

            int a, b, result;
            a = 5;
            b = 10;
            result = a + b;
            
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.Write("Sum of {0} + {1} = {2}", a, b, result);
            }
            Console.WriteLine("Saved");
            Console.ReadKey();
        }
    }
}
