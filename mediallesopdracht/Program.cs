using mediallesopdracht.opdracht_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace mediallesopdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("name?");
            string inputName = Console.ReadLine();
            Console.WriteLine("age?");
            string inputAge = Console.ReadLine();
            Console.WriteLine("your name is " + inputName + " and you are " + inputAge + " years old.");
            */

            /* downstairs test = new downstairs();
              test.Start();
            */

            weather condition = new weather();
            condition.Outside();

        }
    }
}
