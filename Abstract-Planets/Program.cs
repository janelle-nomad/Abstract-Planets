﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

/*
    Author: Janelle Heron
    Student #: 300839820    
    Date Created: July 1 2016
    Date Modified: July 8 2016 
    Description: Program runs 
    Version 0.0.1 - Both Giant and Terrestrial planet classes have been created
 */
namespace Abstract_Planets
{
    /*
     * @Driver Class
     * Used to display planet information
     * Description: Contains Planet, GiantPlanet and Terrestrial Planet classes respectively
     * **/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PLANETARY INFORMATION");

            Planet Troidia = new TerrestrialPlanet("Troidia", 79, 79, false);
            Console.WriteLine("_______________________________________________");
            Console.WriteLine(Troidia.ToString()); //Based on the overide method
            Console.WriteLine("_______________________________________________");

            Planet Thessia = new TerrestrialPlanet("Thessia", 102.97, 102.97, true);
            Console.WriteLine("_______________________________________________");
            Console.WriteLine(Thessia.ToString());
            Console.WriteLine("_______________________________________________");

            Planet Venus = new GiantPlanet("Tukchana", 108.2, 97, "Fire");
            Console.WriteLine("_______________________________________________");
            Console.WriteLine(Venus.ToString());
            Console.WriteLine("_______________________________________________");

            Console.WriteLine("Press a key to end program");
            Console.ReadKey();
        }
    }
}
