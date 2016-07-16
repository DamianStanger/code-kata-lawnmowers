using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace LawnMowers.Tests
{
    public class ConsoleReporterTests
    {
        private readonly ConsoleReporter _consoleReporter;
        private readonly MockConsoleAdapter _mockConsoleAdapter;

        public ConsoleReporterTests()
        {
            _mockConsoleAdapter = new MockConsoleAdapter();
            _consoleReporter = new ConsoleReporter(_mockConsoleAdapter);
        }

        [Fact]
        public void ShouldReportNothing()
        {            
            _consoleReporter.ReportOn(new List<Mower>());

            _mockConsoleAdapter.Lines.Should().BeEmpty();
        }

        [Fact]
        public void ShouldReportCoordinates()
        {
            var mowers = new List<Mower>() {new Mower("1 2 N", "")};

            _consoleReporter.ReportOn(mowers);

            _mockConsoleAdapter.Lines.Count.Should().Be(1);
            _mockConsoleAdapter.Lines[0].Should().StartWith("1 2");
        }

        [Fact]
        public void ShouldReportHeading()
        {
            var mowers = new List<Mower>() { new Mower("1 2 N", "") };

            _consoleReporter.ReportOn(mowers);

            _mockConsoleAdapter.Lines.Count.Should().Be(1);
            _mockConsoleAdapter.Lines[0].Should().EndWith("N");
        }

        [Fact]
        public void ShouldReportTwoMowers()
        {
            var mowers = new List<Mower>() { new Mower("1 3 N", ""), new Mower("5 1 E", "") };

            _consoleReporter.ReportOn(mowers);

            _mockConsoleAdapter.Lines.Count.Should().Be(2);
            _mockConsoleAdapter.Lines[0].Should().Be("1 3 N");
            _mockConsoleAdapter.Lines[1].Should().Be("5 1 E");
        }
    }

    public class MockConsoleAdapter : ConsoleAdapter
    {
        public MockConsoleAdapter()
        {
            Lines = new List<string>();
        }

        public override void WriteLine(string s)
        {
            Lines.Add(s);
        }

        public List<string> Lines { get; }
    }
}