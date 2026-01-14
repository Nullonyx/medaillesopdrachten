using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mediallesopdracht.opdracht_2
{
    internal class bedroom
    {

        public void Sleepingroom()
        {
            // enter start & leave start//
            Console.WriteLine("You enter the room, will you [LEAVE] or [INSPECT]?");
            string action = Console.ReadLine().ToUpper();
            if (action == "LEAVE")
            {
                Console.Clear();
                upstairs move = new upstairs();
                move.secondfloor();
            }
            // enter end & leave end //

            // inspect start //
            else if (action == "INSPECT")
            {
                Console.WriteLine("It's the bedroom, nothing important here.");
                Thread.Sleep(5000);
                Sleepingroom();
            }
            // inspect end //
        }

    }
}
