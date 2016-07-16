using System.Collections.Generic;

namespace LawnMowers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ICommandReader commandReader = new CommandFileReader("TestData\\test-input.mow");
            Commands commands = commandReader.Read();

            Lawn lawn = new Lawn(commands.LawnSize);
            IList<Mower> mowers = commands.GetMowers();
            foreach (var mower in mowers)
            {
                mower.Mow(lawn);
            }

            IGardenerReporter reporter = new ConsoleReporter(new ConsoleAdapter());
            reporter.ReportOn(mowers);
        }
    }
}
