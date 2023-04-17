namespace assignment3
{
    public class PlayingCard
    {
        public int rank;
        public CardSuit suit;

        public PlayingCard(int rank, CardSuit cardSuit)
        {
            this.rank = rank;
            this.suit = cardSuit;
        }

        public override string ToString()
        {
            string rank = "";
            switch (this.rank)
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
            return $"{rank} of {suit}";
        }
    }
}
