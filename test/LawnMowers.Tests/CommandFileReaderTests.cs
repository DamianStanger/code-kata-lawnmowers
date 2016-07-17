using System;
using System.IO;
using FluentAssertions;
using Xunit;

namespace LawnMowers.Tests
{
    public class CommandFileReaderTests
    {
        [Fact]
        public void RetunsPopulatedCommandsObject()
        {
            var commandReader = new CommandFileReader("TestData\\test-file.mow");
            var commands = commandReader.Read();

            commands.Count.Should().Be(3);
            commands[0].Should().Be("Line 1");
            commands[1].Should().Be("Line 2");
            commands[2].Should().Be("Line 3.");
        }

        [Fact]
        public void ThrowsExceptionWhenFileIssuesOccur()
        {
            var commandReader = new CommandFileReader("TestData\\test-file-missing.mow");

            Exception ex = Assert.Throws<FileNotFoundException>(() => commandReader.Read());

            ex.Message.Should().StartWith("Could not find file");
        }
    }
}

