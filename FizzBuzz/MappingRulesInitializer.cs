using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz.Rules;

namespace FizzBuzz;

public class MappingRulesInitializer
{
    public static IList<IMappingRule> Initialize()
    {
        IList<IMappingRule> rules = new List<IMappingRule>
        {
            new FizzBuzzRule(),
            new FizzRule(),
            new BuzzRule()
        };

        return rules;
    }
}
