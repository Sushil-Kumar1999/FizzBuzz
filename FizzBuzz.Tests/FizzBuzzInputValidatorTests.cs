using FizzBuzz.Exceptions;

namespace FizzBuzz.Tests;

public class FizzBuzzInputValidatorTests
{

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(299)]
    [InlineData(300)]
    public void FizzBuzzValidator_ReturnsTrue_IfInputIs_Valid(int input)
    {
        // arrange
        IInputValidator validator = new FizzBuzzInputValidator();
        // act
        bool output = validator.Validate(input);
        // assert
        Assert.True(output);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(299)]
    [InlineData(300)]
    public void FizzBuzzValidator_DoesNotThrowException_IfInputIs_Valid(int number)
    {
        IInputValidator validator = new FizzBuzzInputValidator();

        var exception = Record.Exception(() => validator.Validate(number));

        Assert.Null(exception);
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(0)]
    [InlineData(301)]
    [InlineData(400)]
    public void FizzBuzzValidator_ThrowsException_IfInputIs_Invalid(int number)
    {
        IInputValidator validator = new FizzBuzzInputValidator();

        var exception = Assert.Throws<ArgumentException>(() => validator.Validate(number));
        Assert.Equal(ExceptionMessages.FizzBuzz_InputOutOfRangeMessage, exception.Message);
    }
}
