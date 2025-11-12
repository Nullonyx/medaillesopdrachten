using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediallesopdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("name?");
            string inputName = Console.ReadLine();
            Console.WriteLine("age?");
            string inputAge = Console.ReadLine();
            Console.WriteLine("your name is " + inputName + " and you are " + inputAge + " years old.");

        }
    }
}
