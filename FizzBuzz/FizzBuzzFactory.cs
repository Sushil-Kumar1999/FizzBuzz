using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz;

public class FizzBuzzFactory : IFactory
{
    public IFlow GetFlow()
    {
        IInputValidator _inputValidator = new FizzBuzzInputValidator();
        IInputMapper _inputMapper = new FizzBuzzInputMapper();
        IOutputBuilder _outputBuilder = new FizzBuzzOutputBuilder(_inputMapper);
        IGenerator _generator = new FizzBuzzGenerator(_inputValidator, _outputBuilder);
        IConsole _console = new FizzBuzzConsole();

        IFlow flow = new FizzBuzzFlow(_generator, _console);
        return flow;
    }
}
