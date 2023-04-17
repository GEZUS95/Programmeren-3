using System;

namespace assignment2
{
    class Dice
    {
        public int value;
        private Random rnd;

        public Dice(Random rnd)
        {
            this.rnd = rnd;
        }

        public void Throw()
        {
            value = rnd.Next(1, 7);
        }

        public void DisplayValue()
        {
            Console.Write(value+" ");
        }
    }
}
