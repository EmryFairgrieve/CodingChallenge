using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge.CardGame
{
    public class PackOfCards : IPackOfCards
    {
        private IList<ICard> _cards;
        private readonly Random _random;

        public PackOfCards(IList<ICard> cards)
        {
            _cards = cards;
            _random = new Random();
            FillDeck();
        }

        public int Count => _cards.Count;

        public IEnumerator<ICard> GetEnumerator()
        {
            return _cards.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Shuffle()
        {
            FillDeck();

            for (var index = _cards.Count - 1; index > 0; --index)
            {
                var randomIndex = _random.Next(index + 1);
                var currentCard = _cards[index];
                _cards[index] = _cards[randomIndex];
                _cards[randomIndex] = currentCard;
            }
        }

        public ICard TakeCardFromTopOfPack()
        {
            var topCard = _cards.FirstOrDefault();
            if (_cards.Any()) { _cards.RemoveAt(0); }
            return topCard;
        }

        public void FillDeck()
        {
            _cards.Clear();

            for (int i = 0; i < 52; i++)
            {
                var suit = (Suit)(i % 4);
                var value = (Value)(i % 13);
                _cards.Add(new Card(suit, value));
            }
        }
    }
}
