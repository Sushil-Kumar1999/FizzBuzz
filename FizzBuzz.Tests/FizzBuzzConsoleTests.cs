using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Tests
{
    public class FizzBuzzConsoleTests
    {
        [Fact]
        public void GivenUserInputHello_ThenReturnHello()
        {
            string input = "Hello";
            var stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            IConsole console = new FizzBuzzConsole();
            string result = console.Read();

            Assert.Equal(input, result);
        }

        [Fact]
        public void FizzBuzzConsole_WritesToConsole()
        {
            string expectedOutput = "Hello World";
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            IConsole console = new FizzBuzzConsole();
            console.Write(expectedOutput);

            string actualOutput = stringWriter.ToString().TrimEnd(new char[] { '\r', '\n' });

            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}
