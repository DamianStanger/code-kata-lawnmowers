using System;
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
            //TODO hadle file not found exceptions
            var streamReader = new StreamReader(new FileStream(_commandFile, FileMode.Open));
            var commands = new Commands();
            while (!streamReader.EndOfStream)
            {
                var readLine = streamReader.ReadLine();
                commands.Add(readLine);
            }
            return commands;
        }
    }
}