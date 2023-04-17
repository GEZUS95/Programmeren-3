﻿using System;

namespace assignment2
{
    class Program
    {
        static void Main()
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            YahtzeeGame yahtzeeGame = new YahtzeeGame();
            PlayYahtzee(yahtzeeGame);
            Console.ReadKey();
        }

        void PlayYahtzee(YahtzeeGame game)
        {
            int pogingen = 0;

            do
            {
                game.Throw();
                game.DisplayValues();
                pogingen++;
            }
            while (!game.Yahtzee());

                Console.WriteLine("Number of attempts needed (for Yahtzee): {0}", pogingen);
        }
    }
}
