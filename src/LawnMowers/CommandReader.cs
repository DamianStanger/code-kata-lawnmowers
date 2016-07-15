using System;
using System.IO;

namespace LawnMowers
{
    public class CommandReader
    {
        public Commands Read(string commandFile)
        {
            var streamReader = new StreamReader(new FileStream(commandFile, FileMode.Open));
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