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
        int actionCounter = 0;
        int dayCounter = 0;
        string owner = null;
        string name = null;

        int hunger = 0;
        int energy = 0;
        int affection = 0;

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

            hunger = hunger - 2;

            if (hunger <= 1)
            {
                Utils.printAt("You need to feed " + name + ", NOW!!!", 17, 4);

            }
            else if (hunger <= 3)
            {
                Utils.printAt("You need to feed" + name, 17, 4);
                getTired();
                getLonely();


            }
            else if (hunger <= 6)
            {

                Utils.printAt(name + " is hungry!!!", 17, 4);

            }
        }

        // is tired
        public void getTired()
        {

            energy = energy - 2;

            if (energy <= 1)
            {

                Utils.printAt(name + " will die of sleep depravation", 17, 5);

            }
            else if (energy <= 3)
            {

                Utils.printAt(name + " REALLY needs to sleep!!!.", 17, 5);
                getLonely();

            }
            else if (energy <= 6)
            {

                Utils.printAt(name + " is tired!!!", 17, 5);

            }
        }

        //fells lonely
        public void getLonely()
        {

            affection = affection - 2;

            if (affection <= 1)
            {
                Utils.printAt(name + " is really depressed!!!", 18, 6);

            }
            else if (affection <= 3)
            {

                Utils.printAt("don't let" + name + " be lonely", 18, 6);
                getTired();

            }
            else if (affection <= 6)
            {

                Utils.printAt(name + " is feeling lonely!!!", 18, 6);
                getTired();

            }
        }

        //ACTIONS
        public void chooseAction()
        {
            Utils.centerText("What do you want to do with your pet:", screen.width, screen.height / 2 - 1);
            Utils.centerText("1)  Feed", screen.width, screen.height / 2 + 1);
            Utils.centerText("2)  Sleep", screen.width, screen.height / 2 + 2);
            Utils.centerText("3)  Love", screen.width, screen.height / 2 + 3);
            Utils.centerText("Select number: ", screen.width, screen.height / 2 + 5);

            int userChoice = int.Parse(Console.ReadLine());

            try
            {
                switch (userChoice)
                {
                    case 1:
                        feed();
                        break;
                    case 2:
                        sleep();
                        break;
                    case 3:
                        love();
                        break;
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Index out of range");
                Console.WriteLine(e);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROOOOOOOOOR!!!!!!!");
                Console.WriteLine(e);
            }
        }


        //has been fed
        public void feed()
        {
            hunger = hunger + 2;

            Utils.printAt(name + " has been fed", 17, 4);

        }

        //sleep
        public void sleep()
        {
            energy = energy + 2;

            Utils.printAt(" (u.u) Zzz", 20, 5);


        }

        //felling loved
        public void love()
        {

            affection = affection + 2;
            Utils.printAt(" <3 ", 20, 6);

        }



        //modify values after actions
        public void timePasses()
        {

            //after
            getHungry();
            getTired();
            getLonely();

            actionCounter++;
            if (actionCounter == 3)
            {
                dayCounter++;
                Utils.printAt("Day " + dayCounter, screen.width - 19, 2);
                actionCounter = 0;
            }


        }
    }
}
