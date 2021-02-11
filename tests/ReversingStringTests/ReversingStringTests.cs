using CodingChallenge.ReversingString;
using Xunit;

namespace ReversingStringTests
{
    public class ReversingStringTests
    {
        [Theory]
        [InlineData("BarBazQux", "xuQzaBraB")]
        [InlineData("Hello Foo", "ooF olleH")]
        [InlineData("a", "a")]
        [InlineData("", "")]
        [InlineData(null, null)]
        public void GivenInputs_Reverse_ReturnsOutputs(string input, string output)
        {
            var result = StringUtilities.Reverse(input);
            Assert.Equal(output, result);
        }
    }
}
