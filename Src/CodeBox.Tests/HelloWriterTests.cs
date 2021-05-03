﻿using ShapeCreator.Core;
using ShapeCreator.Tests.TestHelpers;
using Xunit;
using Xunit.Abstractions;

namespace ShapeCreator.Tests
{
    public class HelloWriterTests : Testbase
    {
        HelloWriter Factory_HelloWriter(TestConsoleOutput testConsoleOutput)
        {
            return new HelloWriter(testConsoleOutput);
        }

        public HelloWriterTests(ITestOutputHelper output):base(output)
        {
           
        }

        [Fact]
        public void Write_TestStringWritten_ShouldMatchOutoutAsExpected()
        {
            //Arrange
            var testConsoleOutput = new TestConsoleOutput(Output);
            var helloWriter = Factory_HelloWriter(testConsoleOutput);
            const string HELLO_PARAM = "Ashraf";
            const string EXPECTED_OUTPUT = "Hello Ashraf\r\n";
           
            //Act
            helloWriter.WriteLine(HELLO_PARAM);

            //Assert
            Assert.Equal(EXPECTED_OUTPUT, testConsoleOutput.ToString());
        }
    }
}
