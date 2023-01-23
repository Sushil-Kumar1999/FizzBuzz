using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Rules;

public class BuzzRule : IMappingRule
{
    public string GetValue()
    {
        return "Buzz";
    }

    public bool IsSatisfiable(int number)
    {
        return number % 5 == 0;
    }
}
