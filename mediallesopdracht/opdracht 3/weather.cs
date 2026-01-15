using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mediallesopdracht.opdracht_3
{
    internal class weather
    {
        public void Outside()
        {
            // setup for weather condition and temperature //
            Console.WriteLine("Is the weather currently Sunny, Rainy or Cloudy?");
            string weather = Console.ReadLine().ToLower();
            if ((weather == "sunny") || (weather == "rainy") || (weather == "cloudy")) // if its either one of these the main code runs //
            {
                Console.WriteLine("And the current temperature outside?");
                string temperature = Console.ReadLine();
                bool temperatureChecker = temperature.All(char.IsDigit);
                if (temperatureChecker == false)
                {
                    Console.WriteLine("The temperature you entered wasn't valid, try again.");
                    Thread.Sleep(4000);
                    Console.Clear();
                    Outside();
                }
                // finished (or denied) checking the user inputted string by temperature if its actually a number or just nonsense //

                else
                {

                    // checking if inputted string is higher then a set number.. //
                    int finaltemp;
                    finaltemp = int.Parse(temperature);
                    if (finaltemp > 20)
                    // finished converting string to int and comparing it to the preset number //
                    {
                        if (weather == "sunny")
                        {
                            Console.WriteLine("It's currently hot and sunny outside, best to stay indoors or in shadows and remember to stay cool.");
                            Thread.Sleep(7000);
                            Console.Clear();
                        }
                        else if (weather == "rainy")
                        {
                            Console.WriteLine("It's still hot outside, it's best to wise to use an umbrella instead of a jacket. ");
                            Thread.Sleep(6000);
                            Console.Clear();
                        }
                        else if (weather == "cloudy")
                        {
                            Console.WriteLine("It's hot outside, but the clouds will make it abit cooler for you.");
                            Thread.Sleep(6000);
                            Console.Clear();
                        }

                    }
                    // end of hot weather condition checking //
                    else
                    {

                        if (weather == "sunny")
                        {
                            Console.WriteLine("It's sunny outside, could be a nice time for a walk.");
                            Thread.Sleep(5000);
                            Console.Clear();
                        }
                        else if (weather == "rainy")
                        {
                            Console.WriteLine("It's raining outside, best advised to wear a jacket and bring an umbrella if needed.");
                            Thread.Sleep(6000);
                            Console.Clear();
                        }
                        else if (weather == "cloudy")
                        {
                            Console.WriteLine("It's cloudy, so it will stay rather cool with potential wind.");
                            Thread.Sleep(6000);
                            Console.Clear();
                        }

                    }

                }
            }
            else // if you didnt input any of the three weathers typed out for you. //
            {
                Console.WriteLine("The weather you tried inputting isn't on the list, please try again.");
                Thread.Sleep(6000);
                Console.Clear();
                Outside();
            }
        }
    }
}
