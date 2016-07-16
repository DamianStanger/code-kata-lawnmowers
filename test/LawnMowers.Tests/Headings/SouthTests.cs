using FluentAssertions;
using LawnMowers.Headings;
using Xunit;

namespace LawnMowers.Tests.Headings
{
    public class SouthTests
    {
        [Fact]
        public void ShouldMoveSouth()
        {
            var south = new South();
            var tuple = south.ProcessCommand('M', new Coordinate(1, 1));

            tuple.Item1.X.Should().Be(1);
            tuple.Item1.Y.Should().Be(0);
        }

        [Fact]
        public void ShouldRotateClockwise()
        {
            var south = new South();
            var tuple = south.ProcessCommand('R', new Coordinate(1, 1));

            tuple.Item2.Should().BeOfType<West>();
        }

        [Fact]
        public void ShouldRotateAntiClockwise()
        {
            var south = new South();
            var tuple = south.ProcessCommand('L', new Coordinate(1, 1));

            tuple.Item2.Should().BeOfType<East>();
        }
    }
}