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
        public Pet(string name, string owner, int hunger, int energy, int affection, Screen screen)
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

        //pet alive
        public bool isAlive()
        {
            return hunger > 0 && energy > 0;
        }

        // is hungry
        public void isHungry()
        {

            hunger = hunger - 1;

            if (hunger <= 15)
            {
              Utils.printAt(name + " is very hungry!!! Need to be feed!!!", 17, 4);

            } else if (hunger <= 10)
            {
                Utils.printAt("You need to feed" + name, 17, 4);

            } else if (hunger <= 1){

                Utils.printAt("You need to feed" + name + ", NOW!!!", 17, 4);

            } 
        }

        // is tired
        public void isTired()
        {

            energy = energy - 1;

            if (energy < 15)
            {

                Utils.printAt(name + " is very tired!!! Need to sleep!!!", 17, 5);

            }
            else if (energy < 10)
            {

                Utils.printAt(name + " REALLY needs to sleep!!!.", 17, 5);

            }
            else if (energy < 5)
            {

                //TODO: puts to sleep

            }
        }

        //fells lonely
        public void feelsLonely()
        {

            affection = affection - 1;

            if (affection <= 15)
            {
                
                Utils.printAt(name + " is feeling lonely, show your love", 17, 6);
                isTired();

            } else if (affection <= 10)
            {

                Utils.printAt(name + " is feelling depressed, don't let it be lonely", 17, 6);
                isTired();

            } else if(affection <= 5)
            {

                Utils.printAt(name + " is is relly depressed!!! Needs your love!!!", 17, 6);
                isTired();

            }
        }

        //has been fed
        public void feed()
        {
            hunger = hunger + 1;

            Utils.printAt(name + " has been fed", 17, 4);

            if(hunger == 10)
            {
                Utils.printAt(name + " is satisfied!!!", 17, 4);
            }
        }

        //sleep
        public void sleep()
        {
            energy = energy + 1;

            //Utils.printAt(name + "is sleeping", width, height/2);
            //Utils.printAt("Zzz", width, height/2 +1);

            if(energy == 10)
            {
                //TODO: awakes
            }
        }

        //felling loved
        public void love()
        {

            affection = affection + 1;

            //TODO, increase by activities?  
        }

        //TODO: Time pass, rest parameters
        //add actions
    }
}
