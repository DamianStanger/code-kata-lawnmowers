using System;
using System.Collections.Generic;

namespace LawnMowers
{
    public class ConsoleReporter : IGardenerReporter
    {
        private readonly ConsoleAdapter _consoleAdapter;

        public ConsoleReporter(ConsoleAdapter consoleAdapter)
        {
            this._consoleAdapter = consoleAdapter;
        }

        public void ReportOn(IList<Mower> mowers)
        {
            foreach (var mower in mowers)
            {
                _consoleAdapter.WriteLine($"{mower.Location.X} {mower.Location.Y} {mower.Heading}");
            }
        }
    }

    public class ConsoleAdapter
    {
        public virtual void WriteLine(string s)
        {
            Console.WriteLine(s);
        }
    }
}