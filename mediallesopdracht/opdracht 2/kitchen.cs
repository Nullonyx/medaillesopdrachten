using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mediallesopdracht.opdracht_2
{
    internal class kitchen
    {
        public static bool Teafound = false;
        // this is used for repeat searching in the kitchen along with tracking the win condition for the garden //
        public void Teahunt()
        {
            // kitchen enter start //
            Console.WriteLine("You find yourself in an room with various cooking equipment.");
            Console.WriteLine("You can [SEARCH] or [LEAVE]");
            string action = Console.ReadLine().ToUpper();
            // kitchen enter end //

            // search start //
            if (action == "SEARCH")
            {
                if (Teafound == false)
                {
                    Console.WriteLine("You look through the kitchen..");
                    Console.WriteLine("You managed to find some tea bags!");
                    Teafound = true;
                    Thread.Sleep(5000);
                    Console.Clear();
                    Teahunt();
                }
                else
                {
                    Console.WriteLine("There's nothing left to look for.");
                    Thread.Sleep(4000);
                    Console.Clear();
                    Teahunt();
                }

            }
            // search end //

            // leave start //
            else if (action == "LEAVE")
            {
                Console.Clear();
                upstairs move = new upstairs();
                move.secondfloor();
            }
            // leave end //
        }

    }
}
