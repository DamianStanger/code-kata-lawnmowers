using System;
using System.Collections;
using System.Collections.Generic;

namespace LawnMowers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Commands commands = new CommandReader().Read("TestData\\test-input.mow");
            Lawn lawn = new Lawn(commands.LawnSize);
            IList<Mower> mowers = commands.GetMowers();            
            Console.WriteLine("1 3 N");
            Console.WriteLine("5 1 E");
        }
    }
}
