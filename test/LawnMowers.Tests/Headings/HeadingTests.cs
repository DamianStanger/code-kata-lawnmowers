using FluentAssertions;
using LawnMowers.Headings;
using Xunit;

namespace LawnMowers.Tests.Headings
{
    public class HeadingTests
    {
        [Fact]
        public void ShouldReturnNorth()
        {
            var heading = Heading.GetHeading("1 1 N");

            heading.Should().BeOfType<North>();
        }

        [Fact]
        public void ShouldReturnSouth()
        {
            var heading = Heading.GetHeading("1 1 S");

            heading.Should().BeOfType<South>();
        }

        [Fact]
        public void ShouldReturnEast()
        {
            var heading = Heading.GetHeading("1 1 E");

            heading.Should().BeOfType<East>();
        }

        [Fact]
        public void ShouldReturnWest()
        {
            var heading = Heading.GetHeading("1 1 W");

            heading.Should().BeOfType<West>();
        }
    }
}