using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petSim
{
    class Utils
    {
        //static -->> can access to it from other classes without the instance
        public static void centerText(string text, int width, int height)
        {
            //centered horizontal (vertical will be by choice)
            Console.SetCursorPosition(width / 2 - text.Length / 2, height);
            Console.Write(text);
        }

        //Print at the position you want by choice
        public static void printAt(string text, int width, int height)
        {
            Console.SetCursorPosition(width, height);
            Console.Write(text);
        }
    }

}


