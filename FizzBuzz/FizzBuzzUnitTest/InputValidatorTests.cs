using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FizzBuzzApp;


namespace FizzBuzzTest
{
    [TestClass]
    public class InputValidatorTests
    {
        [TestMethod]
        public void Input_Should_Be_Bigger_Than_Zero_And_Lower_Than_300()
        {
            var validator = new InputValidator();
            string correctInput = "6";
            string invalidInput = "hej";
            string numberNotInRange = "301";

            bool shouldBeTrue = validator.ValidateUserInput(correctInput);
            bool shouldBeInvalid = validator.ValidateUserInput(invalidInput);
            bool shouldBeOutsideRange = validator.ValidateUserInput(numberNotInRange);

            Assert.AreEqual(true, shouldBeTrue);
            Assert.AreEqual(false, shouldBeInvalid);
            Assert.AreEqual(false, shouldBeOutsideRange);
        }

    }
}
