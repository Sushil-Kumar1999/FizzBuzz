using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Rules
{
    public interface IMappingRule
    {
        bool IsSatisfiable(int number);
        string GetValue();
    }
}
