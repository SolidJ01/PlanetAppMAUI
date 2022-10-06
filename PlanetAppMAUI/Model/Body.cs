using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetAppMAUI.Model
{
    public class Body
    {
        private string englishName;
        public string EnglishName { get { return englishName; } }

        private Mass mass;
        public double MassValue { get { return mass.MassValue; } }
        public int MassExponent { get { return mass.MassExponent; } }

        private double gravity;
        public double Gravity { get { return gravity; } }

        private string discoveryDate;
        public string DiscoveryDate { get { return discoveryDate; } }

        private int avgTemp;
        public int AvgTemp { get { return avgTemp; } }

        public Body(string englishName, Mass mass, double gravity, string discoveryDate, int avgTemp)
        {
            this.englishName = englishName;
            this.mass = mass;
            this.gravity = gravity;
            this.discoveryDate = discoveryDate;
            this.avgTemp = avgTemp;
        }
    }
}
