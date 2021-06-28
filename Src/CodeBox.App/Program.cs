﻿using CodeBox.Core.Command.Infrastructure;

namespace CodeBox.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoleOutPut = new ConsoleOutput();
            var consoleInput = new ConsoleInput();

            var canvasCommandStreamProcessor =
                new CommandStreamProcessor(consoleInput, consoleOutPut);

            canvasCommandStreamProcessor.ProcessCommands();
        }
    }
}
