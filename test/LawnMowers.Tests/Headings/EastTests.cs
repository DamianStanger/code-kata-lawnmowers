using FluentAssertions;
using LawnMowers.Headings;
using Xunit;

namespace LawnMowers.Tests.Headings
{
    public class EastTests
    {
        [Fact]
        public void ShouldMoveEast()
        {
            var east = new East();
            var tuple = east.ProcessCommand('M', new Coordinate(1, 1));

            tuple.Item1.X.Should().Be(2);
            tuple.Item1.Y.Should().Be(1);
        }

        [Fact]
        public void ShouldRotateClockwise()
        {
            var east = new East();
            var tuple = east.ProcessCommand('R', new Coordinate(1, 1));

            tuple.Item2.Should().BeOfType<South>();
        }

        [Fact]
        public void ShouldRotateAntiClockwise()
        {
            var east = new East();
            var tuple = east.ProcessCommand('L', new Coordinate(1, 1));

            tuple.Item2.Should().BeOfType<North>();
        }
    }
}