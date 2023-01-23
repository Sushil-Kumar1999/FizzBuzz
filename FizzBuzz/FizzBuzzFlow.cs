using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz;

public class FizzBuzzFlow : IFlow
{
    private readonly IGenerator _generator;
    private readonly IConsole _console;

    public FizzBuzzFlow(IGenerator generator, IConsole console)
    {
        _generator = generator;
        _console = console;
    }

    public void Run()
    {
        _console.Write("Enter a number between 0 and 300: ");
        string? input = _console.Read();
        int.TryParse(input, out int number);

        _console.Write(_generator.Generate(number));
    }
}
