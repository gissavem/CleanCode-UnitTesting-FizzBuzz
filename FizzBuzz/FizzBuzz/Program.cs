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
            do 
            {
                Console.WriteLine("Please enter a valid integer between 1 and 299.");
                input = Console.ReadLine();
            } while (!validator.ValidateUserInput(input));
            Console.WriteLine($"Running FizzBuzz with: {input}.");
            fizzBuzz.Run(int.Parse(input));
        }


    }
}
