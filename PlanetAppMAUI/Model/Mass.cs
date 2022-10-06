using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetAppMAUI.Model
{
    public class Mass
    {
        private double massValue;
        public double MassValue { get { return massValue; } }

        private int massExponent;
        public int MassExponent { get { return massExponent; } }

        public Mass(double massValue, int massExponent)        {
            this.massValue = massValue;
            this.massExponent = massExponent;
        }

    }
}
