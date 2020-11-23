using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FizzBuzzApp;


namespace FizzBuzzTest
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void Should_Return_Fizz()
        {
            var fizzBuzz = new FizzBuzz();
            int validInt = 3;
            int invalidInt = 5;

            bool validResult = fizzBuzz.Fizz(validInt);
            bool invalidResult = fizzBuzz.Fizz(invalidInt);

            Assert.AreEqual<bool>(true, validResult);
            Assert.AreEqual<bool>(false, invalidResult);
        }
        [TestMethod]
        public void Should_Return_Buzz()
        {
            var fizzBuzz = new FizzBuzz();
            int validInt = 5;
            int invalidInt = 3;

            bool validResult = fizzBuzz.Buzz(validInt);
            bool invalidResult = fizzBuzz.Buzz(invalidInt);

            Assert.AreEqual<bool>(true, validResult);
            Assert.AreEqual<bool>(false, invalidResult);
        }
        [TestMethod]
        public void Should_Return_Universal_Answer()
        {
            var fizzBuzz = new FizzBuzz();
            int validInt = 42;
            int invalidInt = 5;

            bool validResult = fizzBuzz.UniversalAnswer(validInt);
            bool invalidResult = fizzBuzz.UniversalAnswer(invalidInt);

            Assert.AreEqual<bool>(true, validResult);
            Assert.AreEqual<bool>(false, invalidResult);
        }
        [TestMethod]
        public void Input_Should_Be_Bigger_Than_Zero_And_Lower_Than_300()
        {
            var fizzBuzz = new FizzBuzz();
            string correctInput = "6";
            string invalidInput = "hej";
            string numberNotInRange = "301";

            bool shouldBeTrue = fizzBuzz.ValidateUserInput(correctInput);
            bool shouldBeInvalid = fizzBuzz.ValidateUserInput(invalidInput);
            bool shouldBeOutsideRange = fizzBuzz.ValidateUserInput(numberNotInRange);

            Assert.AreEqual<bool>(true, shouldBeTrue);
            Assert.AreEqual<bool>(false,shouldBeInvalid);
            Assert.AreEqual<bool>(false, shouldBeOutsideRange);


        }
    }
}
