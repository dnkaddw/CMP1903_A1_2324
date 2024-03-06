using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        Die DiceNumber = new Die(); //allows the functions below to assign the returned value in Die class to the different die objects
        private int die1;
        private int die2;
        private int die3;
        private int result;

        public int Dice1() //assigns die 1 the random number between 1 and 6 from the Die Class
        {
            die1 = DiceNumber.Roll();
            return die1;
        }

        public int Dice2() //assigns die 2 a random number between 1 and 6 from the Die Class
        {
            die2 = DiceNumber.Roll();
            return die2;
        }

        public int Dice3() //assigns die 3 a random number between 1 and 6 from the Die Class   
        {
            die3 = DiceNumber.Roll();
            return die3;
        }

        public int DiceRollResult() //calculates the rum of the 3 dice
        {
            result = die1 + die2 + die3;
            return result;
        }

        public void outputting() //outputs the random number of each die
        {
            Console.WriteLine("Die 1: " + Dice1());
            Console.WriteLine("Die 2: " + Dice2());
            Console.WriteLine("Die 3: " + Dice3());
            Console.WriteLine("Sum of die: " + DiceRollResult());
        }
    }
}
