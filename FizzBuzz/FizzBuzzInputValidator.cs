using System;
using FizzBuzz.Exceptions;

namespace FizzBuzz;

public class FizzBuzzInputValidator : IInputValidator
{
    public virtual bool Validate(int input)
    {
        if (input < 1 || input > 300) 
        {
            throw new ArgumentException(ExceptionMessages.FizzBuzz_InputOutOfRangeMessage);
        }

        return true;
    }
}
