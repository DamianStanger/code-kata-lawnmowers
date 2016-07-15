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

        [Fact]
        public void ShouldGetSingleMower()
        {
            var commands = new Commands() { "line1", "1 2 N", "LMLMLMLMM" };
            var mowers = commands.GetMowers();

            mowers.Count.Should().Be(1);            
        }

        [Fact]
        public void ShouldGetMultipleMowers()
        {
            var commands = new Commands() { "line1", "1 1 N", "L", "2 2 S", "R" };
            var mowers = commands.GetMowers();

            mowers.Count.Should().Be(2);
        }
    }
}