using System;

namespace FizzBuzzApp
{
    public class FizzBuzz
    {
        public void Run(int fizzBuzzNumber)
        {
            var result = "";

            for (int i = 1; i <= fizzBuzzNumber; i++)
            {

                if(Fizz(i))
                {
                    result = "Fizz";
                }
                if(Buzz(i))
                {
                    result += "Buzz";
                }
                if (UniversalAnswer(i))
                {
                    result = "Answer to the Ultimate Question of Life, the Universe, andEverything";
                }
                if (string.IsNullOrEmpty(result))
                {
                    result = i.ToString();
                }
                Console.WriteLine(result);
                result = "";
            }
        }
        public bool Fizz(int i) => i % 3 == 0;
        public bool Buzz(int i) => i % 5 == 0;
        public bool UniversalAnswer(int i) => i == 42;
    }

}
