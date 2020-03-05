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
        Screen screen = null;
        string owner = null;
        string name = null;

        int hunger = 0;
        int energy = 0;
        int affection = 0;

        private int pointerPosition;
        string select;
        string pointer = "  <<--";
        string emptyPointer = "";

        //constructor
        public Pet(string name, string owner, int hunger, int energy, int affection, Screen currentScreen)
        {
            this.name = name;
            this.owner = owner;
            this.hunger = hunger;
            this.energy = energy;
            this.affection = affection;
            this.screen = currentScreen;

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
        public void getHungry()
        {

            hunger = hunger - 1;

            if (hunger <= 3)
            {
                Utils.printAt("You need to feed " + name + ", NOW!!!", 17, 4);
                getTired();
                getLonely();

            } else if (hunger <= 10)
            {
                Utils.printAt("You need to feed" + name, 17, 4);
                getTired();
                getLonely();
                

            } else if (hunger <= 15){

                Utils.printAt(name + " is very hungry!!! Need to be feed!!!", 17, 4);

            } 
        }

        // is tired
        public void getTired()
        {

            energy = energy - 1;

            if (energy <= 3)
            {

                Utils.printAt(name + " if you don't take care of " + name + ", it will die!!!", 17, 5);
                getLonely();

            }
            else if (energy <= 10)
            {

                Utils.printAt(name + " REALLY needs to sleep!!!.", 17, 5);
                getLonely();

            }
            else if (energy <= 15)
            {

                Utils.printAt(name + " is very tired!!! Need to sleep!!!", 17, 5);

            }
        }

        //fells lonely
        public void getLonely()
        {

            affection = affection - 1;

            if (affection <= 3)
            {
                Utils.printAt(name + " is is relly depressed!!! Needs your love!!!", 18, 6);
                getTired();

            } else if (affection <= 10)
            {

                Utils.printAt(name + " is feelling depressed, don't let it be lonely", 18, 6);
                getTired();

            } else if(affection <= 15)
            {

                Utils.printAt(name + " is feeling lonely, show your love", 18, 6);
                getTired();

            }
        }

        //ACTIONS
        public void chooseAction()
        {
            Utils.centerText("Choose an action:", screen.width, screen.height / 2 -1);
            Utils.centerText("", screen.width, screen.height / 2);
            Utils.centerText("Feed"+ pointer, screen.width, screen.height / 2 + 1);
            Utils.centerText("Sleep", screen.width, screen.height / 2 + 2);
            Utils.centerText("Give Love", screen.width, screen.height / 2 + 3);
        }

        public void selectionPointer()
        {
             
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

            Utils.printAt(name + "is sleeping", screen.width, screen.height/2);
            Utils.printAt("Zzz", screen.width, screen.height/2 +1);
            
            //TODO: block other actions

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
        public void days()
        {
            //call resting functions
            getHungry();
            getTired();
            getLonely();

            //counter of a day every 5 mins
            int counter = 300;
            for (int i = 0; i > counter; i ++) {
                //days!
            }
            //counting days

        }
        //add actions
    }
}
