using System;

namespace assignment2
{
    class YahtzeeGame
    {
        public Dice[] dices = new Dice[5];

        public YahtzeeGame()
        {
            Random rnd = new Random();
            for (int i = 0; i < dices.Length; i++)
            {
                dices[i] = new Dice(rnd);
            }
        }

        public void Throw()
        {
            for (int i = 0; i < dices.Length; i++)
            {
                dices[i].Throw();
            }
        }

        public void DisplayValues()
        {
            for (int i = 0; i < dices.Length; i++)
            {
                dices[i].DisplayValue();
            }
            Console.WriteLine();
        }

        public bool Yahtzee()
        {
            int checkval = dices[0].value;
            int count = 0;

            for (int i = 0; i < dices.Length; i++)
            {
                if (dices[i].value == checkval)
                {
                    count++;
                }
            }

            return (count == dices.Length);

        }
    }
}
