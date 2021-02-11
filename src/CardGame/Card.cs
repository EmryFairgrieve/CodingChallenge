namespace CodingChallenge.CardGame
{
    public class Card : ICard
    {
        public Card(Suit suit, Value value)
        {
            Suit = suit;
            Value = value;
        }

        public Suit Suit { get; }

        public Value Value { get; }

        public bool Equals(ICard other)
        {
            return Suit == other.Suit && Value == other.Value;
        }
    }
}
