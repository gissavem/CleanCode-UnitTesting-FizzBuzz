using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzApp
{
    public class FizzBuzz
    {
        public void Run()
        {
            string input;
            do { input = Console.ReadLine(); } while (ValidateUserInput(input));

            int validatedInput = int.Parse(input);
            var result = "";

            for (int i = 1; i <= validatedInput; i++)
            {
                if(UniversalAnswer(i))
                {
                    result = "Answer to the Ultimate Question of Life, the Universe, andEverything";
                }
                if(Fizz(i))
                {
                    result = "Fizz";
                }
                if(Buzz(i))
                {
                    result += "Buzz";
                }
                if(string.IsNullOrEmpty(result))
                {
                    result = i.ToString();
                }
                Console.WriteLine(result);
                result = "";
            }
        }

        public bool ValidateUserInput(string input)
        {
            var valid =  int.TryParse(input, out var number);
            bool inRange = number < 0 || number > 299;
            return valid && inRange;
        }

        public bool Fizz(int i) => i % 3 == 0 ? true : false;


        public bool Buzz(int i) => i % 5 == 0 ? true : false;


        public bool UniversalAnswer(int i) => i == 42 ? true : false;

    }

}
