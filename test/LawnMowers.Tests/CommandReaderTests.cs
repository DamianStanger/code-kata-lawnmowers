using FluentAssertions;
using Xunit;

namespace LawnMowers.Tests
{
    public class CommandReaderTests
    {
        [Fact]
        public void RetunsPopulatedCommandsObject()
        {
            var commandReader = new CommandReader();
            var commands = commandReader.Read("TestData\\test-file.mow");

            commands.Count.Should().Be(3);
            commands[0].Should().Be("Line 1");
            commands[1].Should().Be("Line 2");
            commands[2].Should().Be("Line 3.");
        }
    }
}