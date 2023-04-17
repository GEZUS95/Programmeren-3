using System.Collections.Generic;

namespace assignment3
{
    public class Player
    {
        public string name;
        public List<PlayingCard> cards = new List<PlayingCard>();
        
        public Player(string name)
        {
            this.name = name;
        }

        public void AddCard(PlayingCard card)
        {
            cards.Add(card);
        }

        public PlayingCard GetNextCard()
        {
            PlayingCard first = cards[0];
            cards.RemoveAt(0);
            return first;
        }
    }
}
