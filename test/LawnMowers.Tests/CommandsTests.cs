using FluentAssertions;
using Xunit;

namespace LawnMowers.Tests
{
    public class CommandsTests
    {
        [Fact]
        public void ShouldReturnFirstCommandAsLawnSize()
        {
            var commands = new Commands() {"line1", "line2"};

            commands.LawnSize.Should().Be("line1");
        }
    }
}