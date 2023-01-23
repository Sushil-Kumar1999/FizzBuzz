using Moq;

namespace FizzBuzz.Tests;

public class FizzBuzzFlowTests
{
    private readonly Mock<IGenerator> _generator;
    private readonly Mock<IConsole> _console;

    public FizzBuzzFlowTests()
    {
        _generator = new Mock<IGenerator>();
        _console = new Mock<IConsole>();
    }

    [Fact]
    public void FizzBuzzFlow_RunsHappyPath()
    {
        // arrange
        string userInput = "5";
        string generatorOutput = "1,2,Fizz";
        IFlow flow = new FizzBuzzFlow(_generator.Object, _console.Object);
        _generator.Setup(m => m.Generate(It.IsAny<int>())).Returns(generatorOutput);
        _console.Setup(m => m.Read()).Returns(userInput);

        // act
        flow.Run();

        // assert
        _console.Verify(m => m.Write("Enter a number between 0 and 300: "), Times.Once());
        _generator.Verify(x => x.Generate(5), Times.Once);
        _console.Verify(m => m.Write(generatorOutput), Times.Once());
    }
}
