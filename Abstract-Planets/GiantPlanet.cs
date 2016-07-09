using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Planets
{
    public class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        private string _type;

        public string Type
        {
            get
            {
                return _type;
            }

            set { _type = value; }
        }

        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            return false;
        }

        public bool HasRings()
        {
            if (RingCount > 0)
            {
                return true;
            }
            return false;
        }

        public GiantPlanet(string name, double diameter, double mass, string type) : base(name, diameter, mass)
        {
            this.Type = type;
            
        
        }

        public override string ToString()
        {
            return base.ToString() + String.Format("\n{0} is of Type: {1}", this.Name, Type);
        }
    }
}