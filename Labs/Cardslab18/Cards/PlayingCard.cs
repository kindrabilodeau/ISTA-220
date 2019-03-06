namespace Cards
{
    class PlayingCard
    {
        private readonly Suit suit;
        private readonly Value value;

        public PlayingCard(Suit s, Value v)
        {
            this.suit = s;
            this.value = v;
        }

        public override string ToString()
        {
            string result = $"{value} of {suit}";
            return result;
        }

        public Suit CardSuit //property 
        {
            get { return this.suit;}
        }

        public Value CardValue //property 
        {
            get { return this.value;}
        }
    }
}