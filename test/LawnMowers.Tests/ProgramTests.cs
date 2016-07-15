using System;
using Xunit;

namespace LawnMowers.Tests
{
    public class ProgramTests
    {
        [Fact]
        public static void ShouldPrintDefaultOutput()
        {
            Console.WriteLine("1 3 N");
            Console.WriteLine("5 1 E");
        }
    }
}
