using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mediallesopdracht
{
    internal class downstairs
    {
        public static bool Housekey = false;
        private bool RoomPaperObtained;
        public void Start()
        {
            // dialogue start//
            Console.WriteLine("You are currently standing in a hallway.");
            Console.WriteLine("To your left is a room and to the right are some stairs.");
            Console.WriteLine(". . .");
            Console.WriteLine("You can choose to [INSPECT] the room, or move [LEFT] or [RIGHT].");
            Console.WriteLine("");

            string action = Console.ReadLine().ToUpper();
            //dialogue end//

            //inspect start//
            if (action == "INSPECT")
            {
                Console.WriteLine("");
                Console.WriteLine("You look around the hallway. A drawer stands in it's lonesome as the only piece of furniture.");
                Console.WriteLine("...");
                if (Housekey == true)
                {
                    Console.WriteLine("You... Already have the key.");
                    Thread.Sleep(3000);
                    Console.WriteLine("You decide to look through the drawer again anyway.");
                    Thread.Sleep(3000);
                    Console.WriteLine("You grabbed the paper you left behind. You can [READ] it to find out what it contains.");
                    Thread.Sleep(6000);
                    RoomPaperObtained = true;
                    Console.Clear();
                    Start();
                }
                else
                {
                    Console.WriteLine("You searched through the drawer and found a key.");
                    Thread.Sleep(4000);
                    Housekey = true;
                    Console.WriteLine("There's also a piece of paper in the drawer but you decide to leave it there for now.");
                    Thread.Sleep(6000);
                    Console.Clear();
                    Start();
                }
                //inspect end//
            }
            //upstairs transition//
            else if (action == "RIGHT")
            {
                Console.Clear();
                upstairs move = new upstairs();
                move.secondfloor();
            }

            //living room entrance check//
            else if (action == "LEFT")
            {
                Console.WriteLine("");
                Console.WriteLine("You try to walk into the left room.");
                Console.WriteLine("Unfortunately for you, the door is locked. Unless you have a key or want to bash your own door down..");
                if (Housekey == true)
                {
                    Console.Clear();
                    Console.WriteLine("You unlocked the door and entered the room.");
                    Thread.Sleep(4000);
                    Console.Clear();
                    livingroom enter = new livingroom();
                    enter.TheRoom();
                }
                else
                {
                    Thread.Sleep(5000);
                    Console.Clear();
                    Start();
                }
            }
            //check end//

            //room paper check//
            else if (action == "READ")
            {
                if (RoomPaperObtained == true)
                {
                    Console.Clear();
                    Console.WriteLine(" 'You need to find your way to the living room, once there go [RIGHT].");
                    Console.WriteLine("There you shall find the 'room' that you are looking for.");
                    Console.WriteLine("Though you must first get some tea in order to enjoy the spring weather.'");
                    Console.WriteLine("");
                    Console.WriteLine("Interesting...");

                   
                    Thread.Sleep(10000);
                    Console.Clear();
                    Start();
                }
                else
                {
                    Console.WriteLine("There's nothing to read.");
                    Thread.Sleep(3000);
                    Console.Clear();
                    Start();
                }
                //paper check end//
                
                

               

            }
        }
    }
}
