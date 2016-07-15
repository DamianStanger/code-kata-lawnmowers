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
    }
}