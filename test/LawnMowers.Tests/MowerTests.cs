using FluentAssertions;
using Xunit;

namespace LawnMowers.Tests
{
    public class MowerTests
    {
        [Fact]
        public void ShouldSitStillWithNoCommands()
        {
            var mower = new Mower("2 3 N", "");

            mower.Mow(new Lawn("2 3"));

            mower.Location.X.Should().Be(2);
            mower.Location.Y.Should().Be(3);
            mower.Heading.ToString().Should().Be("N");
        }

        [Fact]
        public void ShouldMoveNorth()
        {
            var mower = new Mower("2 3 N", "M");

            mower.Mow(new Lawn("10 10"));

            mower.Location.X.Should().Be(2);
            mower.Location.Y.Should().Be(4);            
        }
    }
}