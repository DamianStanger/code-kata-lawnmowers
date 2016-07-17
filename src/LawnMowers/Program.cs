using System;
using System.Collections.Generic;

namespace LawnMowers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //TODO respond to args to select the command reader strategy (command line vs file reader with optional mow file location)
            ICommandReader commandReader = new CommandFileReader("TestData\\test-input.mow");
            //TODO respond to args to select the gardener reporter strategy (options could be console, file, stream ect)
            IGardenerReporter reporter = new ConsoleReporter(new ConsoleAdapter());

            try
            {
                Commands commands = commandReader.Read();
            
                Lawn lawn = new Lawn(commands.LawnSize);
                IList<Mower> mowers = commands.GetMowers();
                foreach (var mower in mowers)
                {
                    mower.Mow(lawn);
                }
            
                reporter.ReportOn(mowers);
            }
            catch (Exception e)
            {
                reporter.ReportError(e);
            }
        }
    }
}
