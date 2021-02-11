using CodingChallenge.CardGame;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace CardGameTests
{
    public class PackOfCardsCreatorTests
    {
        [Fact]
        public void Create_CreatesAListOf52UniqueCards()
        {
            var cards = new Mock<IList<ICard>>();
            new PackOfCardsCreator(cards.Object).Create();

            cards.Verify(m => m.Clear(), Times.Once());
            cards.Verify(m => m.Add(It.IsAny<ICard>()), Times.Exactly(52));
            cards.Verify(m => m.Add(It.Is<ICard>(c => c.Suit == (Suit)3)), Times.Exactly(13));
            cards.Verify(m => m.Add(It.Is<ICard>(c => c.Value == (Value)12)), Times.Exactly(4));
        }
    }
}
