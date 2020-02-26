using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petSim
{
    class Screen
    {
        //variables
        public int width = 0;
        public int height = 0;
        string horizontalWall = null;
        string verticalWall = null;
        string author = "Copyright: @deredhuzent";
        
        //constructor
        public Screen(int width, int height)
        {
            //setting the view of the screen
            this.width = width;
            this.height = height;

            StringBuilder wallBuilder = new StringBuilder(width);
            StringBuilder columnBuilder = new StringBuilder(height);

            //append (add to the end) the times I need to print -->> width
            wallBuilder.Append('°', width);
            horizontalWall = wallBuilder.ToString(); //convert to string

            //append (add to the end) the times I need to print -->> width
            columnBuilder.Append("|*|");
            columnBuilder.Append(' ', width - 6); // 6 chars of the 2 columns
            columnBuilder.Append("|*|");
            verticalWall = columnBuilder.ToString(); //convert to string
        }

        //print horizontal walls
        public void topDownWalls()
        {
            Console.WriteLine(horizontalWall);
        }

        //print columnwalls
        public void columnWalls()
        {
            Console.WriteLine(verticalWall);
        }

        public void printAuthor()
        {
            Utils.centerText(author, width, height + 2);
        }



        //General Print
        public void PrintScreen()
        {
            Console.SetCursorPosition(0, 0);
            topDownWalls();

            for (int i = 0; i < height; i++) 
            {
                columnWalls();
            }

            topDownWalls();
            printAuthor();
        }
    }
}
