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
        string username = "username";
        string name = "Default";

        int food = 10;
        int energy = 10;
        int affection = 10;

        //constructor
        public Pet(string name)
        {
            this.name = name;
        }

        //ask for name of Pet

    }
}
