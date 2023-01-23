using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Rules;

public class FizzBuzzRule : IMappingRule
{
    public string GetValue()
    {
        return "FizzBuzz";
    }

    public bool IsSatisfiable(int number)
    {
        return number % 3 == 0 && number % 5 == 0;
    }
}
