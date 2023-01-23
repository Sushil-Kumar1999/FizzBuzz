using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz;

public interface IConsole
{
    string Read();
    void Write(string input);
}
