using System;
using System.Collections.Generic;

namespace CodingChallenge.CardGame
{
    public class PackOfCardsCreator : IPackOfCardsCreator
    {
        private readonly IList<ICard> _cards;

        public PackOfCardsCreator(IList<ICard> cards)
        {
            _cards = cards;
        }

        public IPackOfCards Create()
        {
            return new PackOfCards(_cards);
        }
    }
}
