﻿using ShapeCreator.Core.Command.Infrastructure;

namespace ShapeCreator.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoleOutPut = new ConsoleOutput();
            var consoleInput = new ConsoleInput();

            var canvasCommandStreamProcessor =
                new CommandStreamProcessor(consoleInput, consoleOutPut);

            canvasCommandStreamProcessor.ProcessCanvasCommands();
        }
    }
}