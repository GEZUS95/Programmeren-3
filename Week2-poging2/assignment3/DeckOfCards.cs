using System;
using System.Collections.Generic;

namespace assignment3
{
    public class DeckOfCards
    {
        public List<PlayingCard> allPlayingCards;
        public DeckOfCards()
        {
            allPlayingCards = new List<PlayingCard>();
            InitCards();
        }

        private void InitCards()
        {
            foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
            {
                for (int i = 2; i < 15; i++)
                {
                    PlayingCard card = new PlayingCard(i, suit);
                    allPlayingCards.Add(card);
                }
            }
        }

        public void Print()
        {
            foreach (PlayingCard card in allPlayingCards)
            {
                Console.WriteLine(card.ToString());
            }
        }

        public void Shuffle_old()
        {
            Random rnd = new Random();
            int n = allPlayingCards.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                PlayingCard randomCard = allPlayingCards[k];
                allPlayingCards[k] = allPlayingCards[n];
                allPlayingCards[n] = randomCard;
            }
        }

        public void Shuffle()
        {
            Random rnd = new Random(2);
            int totalCards = allPlayingCards.Count;
            PlayingCard tempCard1;
            PlayingCard tempCard2;

            for (int i = 100; i > 0; i--)
            {
                // genereer 2 random getallen uit het totaal van het deck
                int random1 = rnd.Next(totalCards);
                int random2 = rnd.Next(totalCards);
                // sla de kaarten tijdelijk op
                tempCard1 = allPlayingCards[random1];
                tempCard2 = allPlayingCards[random2];
                // wissel de kaarten
                allPlayingCards[random2] = tempCard1;
                allPlayingCards[random1] = tempCard2;
            }
        }
    }
}
