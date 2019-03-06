using System;

namespace Cards
{
    class Pack
    {
        public const int NumSuits = 4; //this is a symbolic constant 
        public const int CardsPerSuit = 13; //this tooo 
        private PlayingCard[,] cardPack;//multidimensal array 
        private Random randomCardSelector = new Random();//random is class that returns a random object 

        public Pack() //this is a constructor 
        {
            this.cardPack = new PlayingCard[NumSuits, CardsPerSuit];
            for (Suit suit = Suit.Clubs; suit <= Suit.Spades; suit++) //suit is an enum 
            {
                for (Value value = Value.Two; value <= Value.Ace; value++)
                {
                    this.cardPack[(int)suit, (int)value]
                         // this instance//casting int to suit,casting in to value 
                         //mulitply by first number(suit) add by second number(value)
                         = new PlayingCard(suit, value);
                }      // creates a new playing card and assigns it to the array 
            }
        }
        public PlayingCard DealCardFromPack()//this is a method that picks a random card 
        {
            Suit suit = (Suit)randomCardSelector.Next(NumSuits);
            while (this.IsSuitEmpty(suit))
            {
                suit = (Suit)randomCardSelector.Next(NumSuits);
            }
            Value value = (Value)randomCardSelector.Next(CardsPerSuit);
            while (this.IsCardAlreadyDealt(suit, value))
            {
                value = (Value)randomCardSelector.Next(CardsPerSuit);
            }
            PlayingCard card = this.cardPack[(int)suit, (int)value];
            this.cardPack[(int)suit, (int)value] = null;
            return card;
        }

        private bool IsSuitEmpty(Suit suit)
        {
            bool result = true;
            for (Value value = Value.Two; value <= Value.Ace; value++)
            {
                if (!IsCardAlreadyDealt(suit, value))
                {
                    result = false; break;
                }
            }
            return result;
        }

        private bool IsCardAlreadyDealt(Suit suit, Value value)
            => (this.cardPack[(int)suit, (int)value] == null);
    }
}
