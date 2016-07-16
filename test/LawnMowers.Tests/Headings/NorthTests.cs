using FluentAssertions;
using LawnMowers.Headings;
using Xunit;

namespace LawnMowers.Tests.Headings
{
    public class NorthTests
    {
        [Fact]
        public void ShouldMoveNorth()
        {
            var north = new North();
            var tuple = north.ProcessCommand('M', new Coordinate(1, 1));

            tuple.Item1.X.Should().Be(1);
            tuple.Item1.Y.Should().Be(2);
        }

        [Fact]
        public void ShouldRotateClockwise()
        {
            var north = new North();
            var tuple = north.ProcessCommand('R', new Coordinate(1, 1));

            tuple.Item2.Should().BeOfType<East>();
        }

        [Fact]
        public void ShouldRotateAntiClockwise()
        {
            var north = new North();
            var tuple = north.ProcessCommand('L', new Coordinate(1, 1));

            tuple.Item2.Should().BeOfType<West>();
        }
    }
}