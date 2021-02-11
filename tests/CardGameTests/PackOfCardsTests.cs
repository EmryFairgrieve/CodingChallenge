using CodingChallenge.CardGame;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace CardGameTests
{
    public class PackOfCardsTests
    {
        private readonly IPackOfCards _packOfCards;
        private readonly IPackOfCards _reference;

        public PackOfCardsTests()
        {
            _packOfCards = new PackOfCards(new List<ICard>());
            _reference = new PackOfCards(new List<ICard>());
        }

        [Fact]
        void GivenAnFullDeck_Shuffle_ReturnsAShuffledDeck()
        {
            Assert.Equal(52, _packOfCards.Count());

            _packOfCards.Shuffle();

            Assert.Equal(52, _packOfCards.Count());
            Assert.False(_reference.First().Equals(_packOfCards.First()));
            Assert.False(_reference.Last().Equals(_packOfCards.Last()));
        }

        [Fact]
        void GivenA51CardDeck_Shuffle_ReturnsAShuffled52CardDeck()
        {
            _packOfCards.TakeCardFromTopOfPack();
            Assert.Equal(51, _packOfCards.Count());

            _packOfCards.Shuffle();

            Assert.Equal(52, _packOfCards.Count());
        }

        [Fact]
        void GivenAnEmptyDeck_Shuffle_ReturnsAShuffled52CardDeck()
        {
            for (int i = 0; i < 52; i++)
            {
                _packOfCards.TakeCardFromTopOfPack();
            }
            Assert.Empty(_packOfCards);

            _packOfCards.Shuffle();

            Assert.Equal(52, _packOfCards.Count());
        }

        [Fact]
        public void GivenDeckOfCards_TakeCardFromTopOfPack_ReturnsTopCardAndRemovesItFromTheDeck()
        {
            var result = _packOfCards.TakeCardFromTopOfPack();

            Assert.Equal(new Card(0, 0), result);
        }
    }
}
