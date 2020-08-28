using System;
using System.Collections.Generic;

namespace Planets
{
    public class MyPlanets
    {
        private string name = "";
        private double mass = 0.0;
        private int diameter = 0;
        private int numberOfMoons = 0;
        private int meanTemperatuere = 0;

        public string PlanetName { get; set; }
        public double PlanetMass { get; set; }
        public int PlanetDiameter { get; set; }
        public int PlanetNumberOfMoons { get; set; }
        public int MeanTemperature { get; set; }

        
        public override string ToString()
        {
            return "Name: " + PlanetName + ", Mass: " + PlanetMass + ", Diameter: " + PlanetDiameter + ", Number of moons: " + PlanetNumberOfMoons +", Mean temperature: " + MeanTemperature ;
        }
    }
}