using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petSim
{
    class Pet
    {
        //variables
        string owner = null;
        string name = null;

        int hunger = 0;
        int energy = 0;
        int affection = 0;

        //constructor
        public Pet(string name, string owner, int hunger, int energy, int affection)
        {
            this.name = name;
            this.owner = owner;
            this.hunger = hunger;
            this.energy = energy;
            this.affection = affection;
        }

        //Pet State
        public void petStatus()
        {
            Utils.printAt("Owner: " + owner, 5, 1);
            Utils.printAt("Name: " + name, 5, 2);
            Utils.printAt("----------------------", 5, 3);
            Utils.printAt("Hunger: " + hunger, 5, 4);
            Utils.printAt("Energy: " + energy, 5, 5);
            Utils.printAt("Affection: " + affection, 5, 6);
        }

        //Time pass, rest parameters
        //add actions
    }
}
