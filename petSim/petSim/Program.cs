using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * MAIN
 * @Copyright: (C) 2020 deredhuzent
 * @Author: Deryana Dhuzent
 * @Version: 1.0.0
 * @summary: 
*/

namespace petSim
{
    class Program
    {
        //screen that can be modify with parameters
        Screen screen = null;
        Pet pet = null;
        int width = 108;
        int height = 26;
        string username = null;
        string petName = null;

        //Constructor
        public Program()
        {
            screen = new Screen(width, height);

        }

        //ask for username
        public void getUsername()
        {
            while (true)
            {
                screen.PrintScreen();
                Utils.centerText("Welcome to PetSim! Before adopting your pet, tell us your name:", width, height / 2);
                Console.SetCursorPosition(width / 2 - 7, height / 2 + 1);
                Console.Write("-->> ");
                username = Console.ReadLine();

                //empty username invalid
                if (string.IsNullOrEmpty(username))
                {
                    screen.PrintScreen();
                    Utils.centerText("You must have a name, tell us your name:", width, height / 2);
                }
                else
                {
                    screen.PrintScreen();
                    Utils.centerText("Your name is " + username + ", is it correct? Yes/No", width, height / 2);
                    Console.SetCursorPosition(width / 2 + 1, height / 2 + 1);
                    string userAnswer = Console.ReadLine();

                    if (userAnswer == "no" || userAnswer == "n" || userAnswer == "NO" || userAnswer == "N")
                    {
                        screen.PrintScreen();
                    }
                    else if (userAnswer == "yes" || userAnswer == "y" || userAnswer == "YES" || userAnswer == "Y")
                    {
                        screen.PrintScreen();
                        return;
                    }
                }
            }
        }

        //ask for pet Name
        public void getPetName()
        {
            while (true)
            {
                screen.PrintScreen();
                Utils.centerText("Now, you must choose a name for your pet:", width, height / 2);
                Console.SetCursorPosition(width / 2 - 7, height / 2 + 1);
                Console.Write("-->> ");
                petName = Console.ReadLine();

                //empty petName invalid
                if (string.IsNullOrEmpty(petName))
                {
                    screen.PrintScreen();
                    Utils.centerText("Your pet must have a name. How would you like to name it?", width, height / 2);
                }
                else
                {
                    screen.PrintScreen();
                    Utils.centerText("Your pet's name is " + petName + ", is it correct? Yes/No", width, height / 2);
                    Console.SetCursorPosition(width / 2 + 1, height / 2 + 1);
                    string userAnswer = Console.ReadLine();

                    if (userAnswer == "no" || userAnswer == "n" || userAnswer == "NO" || userAnswer == "N")
                    {
                        screen.PrintScreen();
                    }
                    else if (userAnswer == "yes" || userAnswer == "y" || userAnswer == "YES" || userAnswer == "Y")
                    {
                        screen.PrintScreen();
                        return;
                    }
                }
            }
        }

        //game cycle
        public void gameLoop()
        {

            do
            {
                //TODO: stats 30
                pet = new Pet(petName, username, 30, 30, 30, screen);

                screen.PrintScreen();
                pet.petStatus();
                pet.chooseAction();
                pet.days();

                Console.ReadLine();
            } while (true);

            

        }

        static void Main(string[] args)
        {

            //screen that can be modify with parameters
            Program program = new Program();

            //TODO: uncomment
            //program.getUsername();
            //program.getPetName();

            program.gameLoop();

            Console.ReadLine();
        }
    }
}
