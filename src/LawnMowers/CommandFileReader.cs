using System.IO;

namespace LawnMowers
{
    public class CommandFileReader : ICommandReader
    {
        private readonly string _commandFile;

        public CommandFileReader(string commandFile)
        {
            _commandFile = commandFile;
        }

        public Commands Read()
        {
            var fileStream = new FileStream(_commandFile, FileMode.Open);
            var commands = new Commands();

            using (var streamReader = new StreamReader(fileStream))
            {
                while (!streamReader.EndOfStream)
                {
                    var readLine = streamReader.ReadLine();
                    commands.Add(readLine);
                }
            }

            return commands;
        }
    }
}