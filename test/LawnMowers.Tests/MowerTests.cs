using FluentAssertions;
using LawnMowers.Headings;
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

        [Fact]
        public void ShouldNotMoveOffTheLawn()
        {
            var mower = new Mower("10 10 N", "MRM");

            mower.Mow(new Lawn("10 10"));

            mower.Location.X.Should().Be(10);
            mower.Location.Y.Should().Be(10);
        }

        [Fact]
        public void ShouldNotMoveOrTurnIfMowerIsPlacedInTheFlowerBeds()
        {
            var mower = new Mower("10 10 N", "MRMR");

            mower.Mow(new Lawn("5 5"));

            mower.Location.X.Should().Be(10);
            mower.Location.Y.Should().Be(10);
            mower.Heading.Should().BeOfType<North>();
        }
    }
}