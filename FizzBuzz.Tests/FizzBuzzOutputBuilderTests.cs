using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Tests;

public class FizzBuzzOutputBuilderTests
{
    private readonly Mock<IInputMapper> _inputMapper;

    private void SetupMocks()
    {
        _inputMapper.Setup(x => x.GetMappedValue(It.Is<int>(x => x % 3 != 0 && x % 5 != 0)))
                    .Returns((int x) => x.ToString());

        _inputMapper.Setup(x => x.GetMappedValue(It.Is<int>(x => x % 3 == 0)))
                    .Returns("Fizz");

        _inputMapper.Setup(x => x.GetMappedValue(It.Is<int>(x => x % 5 == 0)))
                    .Returns("Buzz");

        _inputMapper.Setup(x => x.GetMappedValue(It.Is<int>(x => x % 3 == 0 && x % 5 == 0)))
                    .Returns("FizzBuzz");
    }

    public FizzBuzzOutputBuilderTests()
    {
        _inputMapper = new Mock<IInputMapper>(MockBehavior.Strict);
        SetupMocks();
    }


    [Theory]
    [InlineData(1, "1")]
    [InlineData(2, "1,2")]
    [InlineData(3, "1,2,Fizz")]
    [InlineData(5, "1,2,Fizz,4,Buzz")]
    [InlineData(6, "1,2,Fizz,4,Buzz,Fizz")]
    [InlineData(10, "1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz")]
    [InlineData(15, "1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz")]
    [InlineData(30, "1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz," +
                    "16,17,Fizz,19,Buzz,Fizz,22,23,Fizz,Buzz,26,Fizz,28,29,FizzBuzz")]
    public void FizzBuzzOutputBuilder_Builds_CorrectOutput(int number, string expectedOutput)
    {
        IOutputBuilder outputBuilder = new FizzBuzzOutputBuilder(_inputMapper.Object);
        string actualOutput = outputBuilder.Build(number);

        Assert.Equal(expectedOutput, actualOutput);
    }
}
