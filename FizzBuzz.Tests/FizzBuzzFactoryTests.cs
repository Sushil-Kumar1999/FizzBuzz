namespace FizzBuzz.Tests;

public class FizzBuzzFactoryTests
{
    [Fact]
    public void FizzBuzzFactory_ReturnsFizzBuzzFlow()
    {
        // Given the program is started
        IFactory factory = new FizzBuzzFactory();

        // When the GetFlow method is called
        IFlow flow = factory.GetFlow();

        // Then we get back a FizzBuzzFlow object
        Assert.NotNull(flow);
    }
}
