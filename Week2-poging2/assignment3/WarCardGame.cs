using System;

namespace assignment3
{
    public class WarCardGame : CardGame
    {
        public Player player1;
        public Player player2;

        public WarCardGame(Player p1, Player p2)
        {
            player1 = p1;
            player2 = p2;
        }

        public void StartNewGame()
        {
            deck.Shuffle();
            for (int i = deck.allPlayingCards.Count - 1; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    player1.AddCard(deck.allPlayingCards[i]);
                }
                else
                {
                    player2.AddCard(deck.allPlayingCards[i]);
                }
            }
        }

        public bool EndOfGame()
        {
            return ((player1.cards.Count == 0) || (player2.cards.Count == 0));
        }

        public void NextCard()
        {
            PlayingCard cardP1 = player1.GetNextCard();
            PlayingCard cardP2 = player2.GetNextCard();

            Console.WriteLine($"[{player1.name}] {cardP1.ToString()} - [{player2.name}] {cardP2.ToString()}");

            if (cardP1.rank > cardP2.rank)
            {
                player1.AddCard(cardP1);
                player1.AddCard(cardP2);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{player1.name} got the cards");
                Console.ResetColor();
            }
            else if (cardP1.rank < cardP2.rank)
            {
                player2.AddCard(cardP2);
                player2.AddCard(cardP1);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{player2.name} got the cards");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("2 cards lost...");
                Console.WriteLine($"cards left: [{player1.name}] {player1.cards.Count}x, [{player2.name}] {player2.cards.Count}x");
            }
        }


    }
}
