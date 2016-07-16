using FluentAssertions;
using LawnMowers.Headings;
using Xunit;

namespace LawnMowers.Tests.Headings
{
    public class WestTests
    {
        [Fact]
        public void ShouldMoveWest()
        {
            var west = new West();
            var tuple = west.ProcessCommand('M', new Coordinate(1, 1));

            tuple.Item1.X.Should().Be(0);
            tuple.Item1.Y.Should().Be(1);
        }

        [Fact]
        public void ShouldRotateClockwise()
        {
            var west = new West();
            var tuple = west.ProcessCommand('R', new Coordinate(1, 1));

            tuple.Item2.Should().BeOfType<North>();
        }

        [Fact]
        public void ShouldRotateAntiClockwise()
        {
            var west = new West();
            var tuple = west.ProcessCommand('L', new Coordinate(1, 1));

            tuple.Item2.Should().BeOfType<South>();
        }
    }
}