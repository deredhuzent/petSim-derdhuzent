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

        //pet alive
        public bool isAlive()
        {
            return hunger > 0 && energy > 0;
        }

        // is hungry
        public void isHungry()
        {

            hunger = hunger - 1;

            if (hunger< 5)
            {
              Console.WriteLine(name + " is very hungry!!! Need to be feed!!!");

            } else if (hunger < 3)
            {
                Console.WriteLine("You need to feed" + name);

            } else if (hunger < 1){

                Console.WriteLine("You need to feed" + name + ", NOW!!!");

            } 
        }

        // is tired
        public void isTired()
        {

            energy = energy - 1;

            if (energy < 5)
            {

                Console.WriteLine(name + " is very tired!!! Need to sleep!!!");

            }
            else if (energy < 3)
            {

                Console.WriteLine(name + " REALLY needs to sleep!!!.");

            }
            else if (energy < 1)
            {

                //TODO: puts to sleep

            }
        }

        //fells lonely
        public void feelsLonely()
        {

            affection = affection - 1;

            //TODO
        }

        //has been fed
        public void feed()
        {
            hunger = hunger + 1;

            Console.WriteLine(name + " has been fed");

            if(hunger == 10)
            {
                Console.WriteLine(name + " is satisfied!!!");
            }
        }

        //sleep
        public void sleep()
        {
            energy = energy + 1;

            Console.WriteLine(name + "is sleeping");

            if(energy == 10)
            {
                //TODO: awakes
            }
        }

        //felling loved
        public void love()
        {

            affection = affection + 1;

            //TODO
        }

        //Time pass, rest parameters
        //add actions
    }
}
