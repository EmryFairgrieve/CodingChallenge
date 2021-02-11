using CodingChallenge.CardGame;
using Xunit;

namespace CardGameTests
{
    public class CardTests
    {
        [Fact]
        public void GivenMatchingCards_Equals_ReturnsTrue()
        {
            var aCard = new Card((Suit)3, (Value)3);
            var anotherCard = new Card((Suit)3, (Value)3);
            Assert.True(aCard.Equals(anotherCard));
        }

        [Fact]
        public void GivenMatchingSuitButDifferentValue_Equals_ReturnsFalse()
        {
            var aCard = new Card((Suit)3, (Value)3);
            var anotherCard = new Card((Suit)3, (Value)7);
            Assert.False(aCard.Equals(anotherCard));
        }

        [Fact]
        public void GivenMatchingValueButDifferentSuit_Equals_ReturnsFalse()
        {
            var aCard = new Card((Suit)3, (Value)3);
            var anotherCard = new Card((Suit)1, (Value)3);
            Assert.False(aCard.Equals(anotherCard));
        }

        [Fact]
        public void GivenDifferentSuitAndValue_Equals_ReturnsFalse()
        {
            var aCard = new Card((Suit)3, (Value)3);
            var anotherCard = new Card((Suit)1, (Value)12);
            Assert.False(aCard.Equals(anotherCard));
        }
    }
}
