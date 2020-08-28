using System;
using System.Collections.Generic;

namespace Planets
{
    class Program
    {
        static void Main(string[] args)
        {
            //making a list of planets
            List<MyPlanets> planets = new List<MyPlanets>();
            
            //Adding planets to my list
            planets.Add(new MyPlanets(){PlanetName = "Merkur", PlanetMass = 0.330, PlanetDiameter = 4879, PlanetNumberOfMoons = 0, MeanTemperature = 167});
            planets.Add(new MyPlanets(){PlanetName = "Jorden", PlanetMass = 5.97, PlanetDiameter = 12756, PlanetNumberOfMoons = 1, MeanTemperature = 15});
            planets.Add(new MyPlanets(){PlanetName = "Mars", PlanetMass = 0.642, PlanetDiameter = 6792, PlanetNumberOfMoons = 2, MeanTemperature = -65});
            planets.Add(new MyPlanets(){PlanetName = "Jupiter", PlanetMass = 1898, PlanetDiameter = 142984, PlanetNumberOfMoons = 67, MeanTemperature = -110});
            planets.Add(new MyPlanets(){PlanetName = "Saturn", PlanetMass = 568, PlanetDiameter = 120536, PlanetNumberOfMoons = 62, MeanTemperature = -140});
            planets.Add(new MyPlanets(){PlanetName = "Uranus", PlanetMass = 86.8, PlanetDiameter = 51118, PlanetNumberOfMoons = 27, MeanTemperature = -195});
            planets.Add(new MyPlanets(){PlanetName = "Neptun", PlanetMass = 102, PlanetDiameter = 49528, PlanetNumberOfMoons = 14, MeanTemperature = -200});
            planets.Add(new MyPlanets(){PlanetName = "Pluto", PlanetMass = 0.0146, PlanetDiameter = 2370, PlanetNumberOfMoons = 5, MeanTemperature = -225});

            //writing my list of planets out to the console
            foreach (MyPlanets aPlanet in planets)
            {
                Console.WriteLine(aPlanet);
            }
            
            //Inserting a new planet at indes 1 - making it number 2 in the visuel list because an index always starts at 0
            planets.Insert(1, new MyPlanets(){PlanetName = "Venus", PlanetMass = 4.87, PlanetDiameter = 12104, PlanetNumberOfMoons = 0, MeanTemperature = 465});

            //Writing my new updatet list to the console including the new added planet
            foreach (MyPlanets aPlanet in planets)
            {
                Console.WriteLine(aPlanet);
            }

            //setting a default vaalue so that I can use it in my foreach bellow
            int pIndex = 0;

            //checking what index Pluto are at
            foreach (MyPlanets x in planets)
            {
                if (x.PlanetName.Equals("Pluto"))
                {
                    pIndex = planets.IndexOf(x);
                }
            }

            //removing pluto
            planets.RemoveAt(8);
            
            //checking that pluto have been removed
            foreach (MyPlanets aPlanet in planets)
            {
                Console.WriteLine(aPlanet);
            }
            
            //insetting pluto again
            planets.Add(new MyPlanets(){PlanetName = "Pluto", PlanetMass = 0.0146, PlanetDiameter = 2370, PlanetNumberOfMoons = 5, MeanTemperature = -225});

            Console.WriteLine("The amonut of planet is " + planets.Count);
            
            
            //creating a new list to work with
            List<MyPlanets> lowTemp = new List<MyPlanets>();
            lowTemp = planets;
            

            //making sure to only use the planets that have a temperature on 0 or bellow
            foreach (MyPlanets lowest in lowTemp)
            {
                if (lowest.MeanTemperature < 0)
                {
                    Console.WriteLine(lowest);

                }
            }

            //creating a new list to work with
            List<MyPlanets> betweenDiameter = new List<MyPlanets>();
            betweenDiameter = planets;

            //making sure only to show thoes that are bigger than 10000 and smaller than 50000
            foreach (MyPlanets bet in betweenDiameter)
            {
                if (bet.PlanetDiameter > 10000 || bet.PlanetDiameter > 50000)
                {
                    Console.WriteLine(bet);
                }
            }

            planets.Clear();
            
            Console.WriteLine("it should be empty from here: ");
            foreach (MyPlanets aPlanet in planets)
            {
                Console.WriteLine(aPlanet);
            }

        }
    }
}
