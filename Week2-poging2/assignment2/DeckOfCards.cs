using System;
using System.Collections.Generic;

namespace assignment2
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
            string rank = "";
            for (int s = 0; s < 4; s++)
            {
                for (int i = 2; i < 15; i++)
                {
                    switch (i)
                    {
                        case 2: rank = "2"; break;
                        case 3: rank = "3"; break;
                        case 4: rank = "4"; break;
                        case 5: rank = "5"; break;
                        case 6: rank = "6"; break;
                        case 7: rank = "7"; break;
                        case 8: rank = "8"; break;
                        case 9: rank = "9"; break;
                        case 10: rank = "10"; break;
                        case 11: rank = "Jack"; break;
                        case 12: rank = "Queen"; break;
                        case 13: rank = "King"; break;
                        case 14: rank = "Ace"; break;
                        default:
                            break;
                    }

                    PlayingCard card = new PlayingCard(rank, (CardSuit)s);
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
