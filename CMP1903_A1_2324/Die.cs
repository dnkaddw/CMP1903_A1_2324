using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        Random rnd = new Random();

        public int Roll() //generates a random number
        {
            int randomNumber = rnd.Next(1, 7);
            return randomNumber;
        }

    }
}
