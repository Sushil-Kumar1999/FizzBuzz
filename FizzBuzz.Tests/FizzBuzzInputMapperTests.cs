using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Tests;

public class FizzBuzzInputMapperTests
{
    [Theory]
    [InlineData(1, "1")]
    [InlineData(3, "Fizz")]
    [InlineData(5, "Buzz")]
    [InlineData(15, "FizzBuzz")]
    public void FizzBuzzInputMapper_ReturnsCorrectValue(int number, string expectedOutput)
    {
        IInputMapper mapper = new FizzBuzzInputMapper();
        string actualOutput = mapper.GetMappedValue(number);

        Assert.Equal(expectedOutput, actualOutput);
    }
}
