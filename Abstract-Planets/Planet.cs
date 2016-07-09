using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
    Author: Janelle Heron
    Student #: 300839820    
    Assignment: Abstract Planets
    Date Created: July 1 2016
    Date Modified: July 8 2016 
     
*/
namespace Abstract_Planets
{
    public abstract class Planet
    {
        /* Private Instance Variables */
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        /*Public Properties*/
        public double Diameter
        {
            get //Read-only Property, a setter isn't necessary
            {
                return _diameter; // acessing the private instance variable _diameter
            }
        }

        public double Mass //read-only method, aquires mass
        {
            get
            {
                return _mass; // acessing the private instance variable _mass
            }
        }

        public int MoonCount //aquires # of moons
        {
            get
            {
                return _moonCount;
            }

            set { _moonCount = value; } //A setter is necessary here order to access this value
        }

        public string Name
        {
            get
            {
                return _name; //Gets the name of the planet
            }

        }

        public double OrbitalPeriod
        {
            get
            {
                return _orbitalPeriod;
            }

            set { _orbitalPeriod = value; }
        }

        public int RingCount
        {
            get
            {
                return _ringCount;
            }

            set { _ringCount = value; }
        }

        public double RotationPeriod
        {
            get
            {
                return _rotationPeriod;
            }

            set { _rotationPeriod = value; }
        }
        
        /*
         * <summary>
         * Below is the Planet constructor
         * </summary>
         * 
         * **/
        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }

        public override string ToString() //Displays planet information within the driver class
        {
            return String.Format("Name of Planet: {0}\nDiameter of {1}: {2}\nMass of {3}: {4}", this.Name, this.Name, this.Diameter, this.Name, this.Mass);
        }
    }
}