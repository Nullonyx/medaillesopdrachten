using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mediallesopdracht.opdracht_2
{
    internal class bathroom
    {
        public void WorstRoom()
        {
            // bathroom enter //
            Console.WriteLine("....");
            Console.WriteLine("I think you should  just [LEAVE].");
            string action = Console.ReadLine().ToUpper();
            // bathroom end //

            // leave start //
            if (action == "LEAVE")
            {
                Console.Clear();
                upstairs move = new upstairs();
                move.secondfloor();
            }
            // leave end //

            // stubborn inspect start //
            else if (action == "INSPECT")
            {
                Console.WriteLine("It's the bathroom. There is nothing to find here.");
                Thread.Sleep(4000);
                Console.Clear();
                WorstRoom();
            }
            // inspect end //
        }

    }
}
