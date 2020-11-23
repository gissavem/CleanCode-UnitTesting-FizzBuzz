using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzApp
{
    public class InputValidator
    {
        public bool ValidateUserInput(string input)
        {
            var valid = int.TryParse(input, out var number);
            bool inRange = number > 0 && number < 300;
            return valid && inRange;
        }
    }
}
