using mediallesopdracht.opdracht_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mediallesopdracht
{
    internal class upstairs
    {
        public void secondfloor()
        {
            // hallway entrance start //
            Console.WriteLine("");
            Console.WriteLine("...You made it upstairs. Looking around you can find 3 rooms. [LEFT], [MIDDLE] and [RIGHT].");
            Console.WriteLine("You can also head back [DOWN] the stairs or [INSPECT] the intersection.");
            string action = Console.ReadLine().ToUpper();
            // hallway entrance end //

            // inspection start //
            if (action == "INSPECT")
            {
                Console.WriteLine("");
                Console.WriteLine("You look around the intersection in more detail, nothing important could be found or noticed.");
                Console.WriteLine("Except for posters and various paintings being strewn across the walls and the [LEFT] door having a sign with a figure.");
                Thread.Sleep(10000);
                Console.Clear();
                secondfloor();
            }
            // inspection end //

            // heading downstairs start//
            else if (action == "DOWN")
            {
                Console.Clear();

                downstairs test = new downstairs();
                test.Start();
            }
            // heading downstairs end//

            // room transitions start//
            else if (action == "LEFT")
            {
                Console.WriteLine("You enter the door to your left.");
                Thread.Sleep(3000);
                Console.Clear();
                bathroom enter = new bathroom();
                enter.WorstRoom();
            }
            else if (action == "MIDDLE")
            {
                Console.Clear();
                bedroom enter = new bedroom();
                enter.Sleepingroom();
            }
            else if (action == "RIGHT")
            {
                Console.Clear();
                kitchen cook = new kitchen();
                cook.Teahunt();
            }
            // room transitions end //
        }
    }
}
