using System;
using System.IO;
using FluentAssertions;
using Xunit;

namespace LawnMowers.Tests
{
    public class ProgramFixture
    {
        [Fact]
        public void ShouldPrintDefaultOutput()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);            

            Program.Main(null);

            var lines = stringWriter.ToString().Split(new[] {"\r\n"}, StringSplitOptions.RemoveEmptyEntries);

            lines.Length.Should().Be(2);
            lines[0].Should().Be("1 3 N");
            lines[1].Should().Be("5 1 E");
        }

        [Fact]
        public void ShouldReportFatalError()
        {
            //TODO need to extend the functionality of the program main to customise the command reader so it throws errors maybe
        }
    }
}
