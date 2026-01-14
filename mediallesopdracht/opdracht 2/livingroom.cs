using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mediallesopdracht
{
    internal class livingroom
    {
        public void TheRoom()
        {
            // room enter dialogue start
            Console.WriteLine("You find yourself in a new room. either you can [INSPECT] or [LEAVE] the room.");
            string action = Console.ReadLine().ToUpper();
            // room enter dialogue end //

            // inspection start //
            if (action == "INSPECT")
            {
                Console.WriteLine("You inspected the room, this place looks like its meant for relaxation.");
                Thread.Sleep(3000);
                Console.WriteLine("In other words, the living room.");
                Thread.Sleep(4000);
                Console.Clear();
                TheRoom();
            }
            // inspection end //

            // transition 1 start //
            else if (action == "LEAVE")
            {
                Console.Clear();
                downstairs test = new downstairs();
                test.Start();
            }
            // transition 1 end //


            // transition 2 start //
            else if (action == "RIGHT")
            {
                Console.Clear();
                gardens outside = new gardens();
                outside.TheEnd();
            }
            // transition 2 end //
        }

    }
}
