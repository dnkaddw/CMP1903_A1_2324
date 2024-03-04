using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) //allows the dice to keep rolling when the user presses enter
            {
                Game gme = new Game();
                Testing testz = new Testing();

                gme.outputting(); //allows the dice results to show on the screen

                testz.test(); //if the numbers on the die are not between 1 and 6, as well as the sum of them not being within the expected range, an error message will be displayed
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
