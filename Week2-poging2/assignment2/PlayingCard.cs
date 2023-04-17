namespace assignment2
{
    public class PlayingCard
    {
        public string rank;
        public CardSuit suit;

        public PlayingCard(string rank, CardSuit cardSuit)
        {
            this.rank = rank;
            this.suit = cardSuit;
        }

        public override string ToString()
        {
            return $"{rank} of {suit}";
        }
    }
}
