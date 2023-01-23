using Moq;

namespace FizzBuzz.Tests;

public class FizzBuzzGeneratorTests
{
    private readonly Mock<IInputValidator> _inputValidator;
    private readonly Mock<IOutputBuilder> _outputBuilder;

    public FizzBuzzGeneratorTests()
    {
        _inputValidator = new Mock<IInputValidator>(MockBehavior.Strict);
        _outputBuilder = new Mock<IOutputBuilder>(MockBehavior.Strict);
    }

    private void SetupMocks()
    {
        _inputValidator.Setup(x => x.Validate(It.IsAny<int>())).Returns(true);
        _outputBuilder.Setup(x => x.Build(It.IsAny<int>())).Returns("test");
    }

    [Fact]
    public void FizzBuzzGenerator_Invokes_Methods_WithCorrectParams()
    {
        IGenerator fizzBuzzGenerator = new FizzBuzzGenerator(_inputValidator.Object, _outputBuilder.Object);
        int number = 5;
        SetupMocks();

        fizzBuzzGenerator.Generate(number);

        _inputValidator.Verify(x => x.Validate(It.Is<int>(x => x == number)), Times.Once);
        _outputBuilder.Verify(x => x.Build(It.Is<int>(x => x == number)), Times.Once);
    }
}