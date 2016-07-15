using FluentAssertions;
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

            mower.Location.Should().Be("2 3 N");
        }
    }
}