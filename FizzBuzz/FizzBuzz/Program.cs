using System;

namespace FizzBuzzApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzz = new FizzBuzz();
            var validator = new InputValidator();
            string input;
            do { input = Console.ReadLine(); } while (validator.ValidateUserInput(input));

            fizzBuzz.Run(int.Parse(input));
        }


    }
}
