using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz;

public class FizzBuzzOutputBuilder : IOutputBuilder
{
    private readonly IInputMapper _inputMapper;

    public FizzBuzzOutputBuilder(IInputMapper inputMapper)
    {
        _inputMapper = inputMapper;
    }

    public virtual string Build(int input)
    {
        StringBuilder _builder = new StringBuilder();

        for (int number = 1; number <= input; number++)
        {
            _builder.Append(_inputMapper.GetMappedValue(number));

            if (number != input)
            {
                _builder.Append(",");
            }
        }

        return _builder.ToString();
    }
}
