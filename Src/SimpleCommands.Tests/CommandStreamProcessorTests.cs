﻿using SimpleCommands.TestHelpers;
using Xunit;
using Xunit.Abstractions;

namespace SimpleCommands.Tests
{
    public class CommandStreamProcessorTests: CommandTestbase
    {
        public CommandStreamProcessorTests(ITestOutputHelper output) : base(output)
        {

        }

        [Fact]
        public void ProcessCommands_NoCommandPassed_Should()
        {
            //Arrange 
            var commandStreamProcessor =
                Factory_CommandStreamProcessor("CommandHello_SingleCommand_Input.txt");
            var expectedOutput = CommandTestHelpers.ReadFromFile("CommandHello_SingleCommand_Output.txt");

            //Act
            commandStreamProcessor.ProcessCommands();

            //Get output
            var actualOutput = commandStreamProcessor.GetOutput().ToString();

            //Assert
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void ProcessCommands_WrongCommandsPassed_Should()
        {
            //Arrange 
            var commandStreamProcessor =
                Factory_CommandStreamProcessor("CommandHello_MultipleCommand_Input.txt");
            var expectedOutput = CommandTestHelpers.ReadFromFile("CommandHello_MultipleCommand_Output.txt");

            //Act
            commandStreamProcessor.ProcessCommands();

            //Get output
            var actualOutput = commandStreamProcessor.GetOutput().ToString();

            //Assert
            Assert.Equal(expectedOutput, actualOutput);
        }

    }
}