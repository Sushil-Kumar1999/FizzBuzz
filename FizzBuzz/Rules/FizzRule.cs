using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Rules;

public class FizzRule : IMappingRule
{
    public string GetValue()
    {
        return "Fizz";
    }

    public bool IsSatisfiable(int number)
    {
        return number % 3 == 0;
    }
}
