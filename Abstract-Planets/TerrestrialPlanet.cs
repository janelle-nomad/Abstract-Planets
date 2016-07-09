using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Planets
{
    public class TerrestrialPlanet : Planet, IHabitable, IHasMoons
    {
        /*Private Instance Variables*/
        private bool _oxygen;

        //Public Methods
        public bool Oxygen
        {
            get { return _oxygen; }

            set { _oxygen = value; }
        }

        public bool HasMoons()
        {
            if (MoonCount > 0) 
            {
                return true; //Planet posses a moon
            }
            return false; // planet does not pposses a moon
        }

        public bool Habitable() //if the presence of oxygen is found return true
        {
            if (Oxygen == true)
            {
                return true; /*if the presence of oxygen is found return true,
                                if not, declare false
                             */ 
            }
            else
                return false;
        }

        /* 
         * @Constructor
         * @{params: oxygen, name, diameter, mass}
         * @{inheritance {Planet Abstract Class}: name, diameter, mass }
         * Description: Takes all the components of the Planet class including
           variables
             */
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