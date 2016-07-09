using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Planets
{
    public class TerrestrialPlanet : Planet, IHabitable, IHasMoons
    {
        private bool _oxygen;

        public bool Oxygen
        {
            get { return _oxygen; }

            set { _oxygen = value; }
        }

        public bool HasMoons()
        {
            if (MoonCount > 0) 
            {
                return true; //Which means the planet has a moon
            }
            return false;
        }

        public bool Habitable()
        {
            if (Oxygen == true)
            {
                return true;
            }
            else
                return false;
        }

        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
            : base(name, diameter, mass)
        {
            this.Oxygen = oxygen;

        }
        public override string ToString()
        {
            return base.ToString() + String.Format("\n{0} Contains Oxygen: {1}", this.Name, Oxygen);
        }

    }
}