using mediallesopdracht.opdracht_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mediallesopdracht
{
    internal class gardens
    {
        public void TheEnd()
        {
            // room enter start //
            Console.WriteLine("You made it to the garden. Infront of you is a table with a chair, everything needed to enjoy some tea is there.");
            Console.WriteLine("Except for tea, which is missing. Will you [SIT] or [LEAVE]?");
            string action = Console.ReadLine().ToUpper();
            // room enter end //

            // win condition start //
            if (action == "SIT")
            {
                if (kitchen.Teafound == true)
                {
                    Console.Clear();
                    Console.WriteLine("You had some nice tea and enjoyed the spring weather.");
                    Thread.Sleep(5000);
                    Console.Clear();
                    Console.WriteLine("You won!");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You sat down and enjoyed the weather.");
                    Thread.Sleep(3000);
                    Console.WriteLine("If only you had some tea...");
                    Thread.Sleep(3000);
                    Console.Clear();
                    Console.WriteLine("You lost...");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
            }
            // win condition end //

            // room transition start //
            else if (action == "LEAVE")
            {
                Console.Clear();
                livingroom enter = new livingroom();
                enter.TheRoom();
            }
            // room transition end //
        }

    }
}
