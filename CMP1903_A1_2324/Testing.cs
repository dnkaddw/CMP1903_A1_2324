using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method

        public void test()
        {
            Game games = new Game();

            int number1 = games.Dice1();
            int number2 = games.Dice2();
            int number3 = games.Dice3();
            int output = games.DiceRollResult();

            //Debug.Assert checks whether the Dice rolls and the sum are within the expected range.
            Debug.Assert(number1 > 0 && number1 < 7, "Die 1 out of bounds");
            Debug.Assert(number2 > 0 && number2 < 7, "Die 2 out of bounds");
            Debug.Assert(number3 > 0 && number3 < 7, "Die 3 out of bounds");
            Debug.Assert(output >= 3 && output <= 18, "Sum of die out of range");
        }
    }
}
