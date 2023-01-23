namespace FizzBuzz;

public class FizzBuzzGenerator : IGenerator
{
    private readonly IInputValidator _inputValidator;
    private readonly IOutputBuilder _outputBuilder;

    public FizzBuzzGenerator(IInputValidator inputValidator, IOutputBuilder outputBuilder)
    {
        _inputValidator = inputValidator;
        _outputBuilder = outputBuilder;
    }

    public string Generate(int input)
    {
        _inputValidator.Validate(input);
       
        return _outputBuilder.Build(input);
    }
}
