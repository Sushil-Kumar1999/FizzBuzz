using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz.Rules;

namespace FizzBuzz;

public class FizzBuzzInputMapper : IInputMapper
{
    public IList<IMappingRule> _mappingRules;

    public FizzBuzzInputMapper()
    {
        _mappingRules = MappingRulesInitializer.Initialize();
    }

    //public virtual string GetMappedValue(int number)
    //{
    //    IMappingRule? rule = _mappingRules.FirstOrDefault(rule => rule.IsSatisfiable(number));

    //    return rule != null ? rule.GetValue() : number.ToString();
    //}

    public virtual string GetMappedValue(int number)
    {
        if (number % 3 == 0 && number % 5 == 0)
        {
            return "FizzBuzz";
        }
        else if (number % 3 == 0)
        {
            return "Fizz";
        }
        else if (number % 5 == 0)
        {
            return "Buzz";
        }
        else
        {
            return number.ToString();
        }
    }
}
