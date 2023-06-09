﻿using System;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            Player player1 = new Player("John");
            Player player2 = new Player("Emma");
            // create game and play it
            WarCardGame war = new WarCardGame(player1, player2);
            PlayTheGame(war);
        }
        void PlayTheGame(WarCardGame war)
        {
            war.StartNewGame();
            while (!war.EndOfGame())
            {
                war.NextCard();
            }

            if (war.player1.cards.Count == 0)
            {
                Console.WriteLine("{0} has won!", war.player1.name);
            }
            else if (war.player2.cards.Count == 0)
            {
                Console.WriteLine("{0} has won!", war.player2.name);
            }
            else
            {
                Console.WriteLine("tie game");
            }
        }
    }
}
