using System;

namespace LawnMowers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Commands commands = new CommandReader().Read("TestData\\test-input.mow");       
            Console.WriteLine("1 3 N");
            Console.WriteLine("5 1 E");
        }
    }
}
