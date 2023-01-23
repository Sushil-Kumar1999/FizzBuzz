namespace FizzBuzz;

public  class Executor
{
    private readonly IFactory _factory;

    public Executor(IFactory factory)
    {
        _factory = factory;
    }

    public void Execute()
    {
        _factory.GetFlow().Run();
    }
}
