using System;
using FluentAssertions;
using Xunit;

namespace LawnMowers.Tests
{
    public class LawnTests
    {
        [Fact]
        public void ShouldProcessLawnSize()
        {
            var lawn = new Lawn("2 17");
            lawn.X.Should().Be(2);
            lawn.Y.Should().Be(17);
        }

        [Theory]
        [InlineData("foo")]
        [InlineData("1 a")]
        [InlineData("")]
        public void ShouldThrowLawnSizeExceptionForinvalidSize(string lawnSize)
        {
            try
            {
                new Lawn(lawnSize);
                true.Should().BeFalse($"Failed to validate lawn size {lawnSize}");
            }
            catch (Exception e)
            {
                e.GetType().Should().Be<LawnSizeException>();
                e.Message.Should().Be($"{lawnSize} is an invalid lawn size");
            }
        }

        [Theory]
        [InlineData(0,0)]
        [InlineData(2,0)]
        [InlineData(0,17)]
        [InlineData(2,17)]
        public void ShouldBeOnTheLawn(int x, int y)
        {
            var lawn = new Lawn("2 17");
            var isOnLawn = lawn.IsOnLawn(new Coordinate(x, y));
            isOnLawn.Should().BeTrue();
        }

        [Theory]
        [InlineData(-1, 0)]
        [InlineData(0, -1)]
        [InlineData(2, 18)]
        [InlineData(3, 17)]
        public void ShouldBeOffTheLawn(int x, int y)
        {
            var lawn = new Lawn("2 17");
            var isOnLawn = lawn.IsOnLawn(new Coordinate(x, y));
            isOnLawn.Should().BeFalse();
        }
    }
}