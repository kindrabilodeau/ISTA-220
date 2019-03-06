namespace Cards
{
	class PlayingCard //declares a class named playingcard 
	{
        private readonly Suit suit; //declares a field as a readonly
        private readonly Value value;

		public PlayingCard(Suit s, Value v) //constructor and takes two parameters
		{
			this.suit = s; 
			this.value = v;
		}

        public override string ToString() 
		{
            string result = $"{this.value} of {this.suit}";
            return result;
		}

        public Suit CardSuit() //declares a method named cardsuit with no paramaeters 
        {
            return this.suit; //returns the suit 
        }

        public Value CardValue() //same things as cardsuit 
        {
            return this.value; //property is a combo of a field and a method 
        }
	}
}