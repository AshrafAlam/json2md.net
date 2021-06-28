﻿using SimpleCommands.Core.IO;

namespace SimpleCommands.Console
{
    public class ConsoleOutput : OutputBase
    {
        public ConsoleOutput() : base((lineToWrite) => System.Console.WriteLine(lineToWrite))
        {

        }
    }
}