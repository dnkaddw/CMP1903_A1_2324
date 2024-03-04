using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        Die DiceNumber = new Die();
        public int die1;
        public int die2;
        public int die3;
        public int result;

        public int Dice1()
        {
            die1 = DiceNumber.Roll();
            return die1;
        }

        public int Dice2()
        {
            die2 = DiceNumber.Roll();
            return die2;
        }

        public int Dice3()
        {
            die3 = DiceNumber.Roll();
            return die3;
        }

        public int DiceRollResult()
        {
            result = die1 + die2 + die3;
            return result;
        }

        public void outputting()
        {
            Console.WriteLine("Die 1: " + Dice1());
            Console.WriteLine("Die 2: " + Dice2());
            Console.WriteLine("Die 3: " + Dice3());
            Console.WriteLine("Sum: " + DiceRollResult());
        }
    }
}
