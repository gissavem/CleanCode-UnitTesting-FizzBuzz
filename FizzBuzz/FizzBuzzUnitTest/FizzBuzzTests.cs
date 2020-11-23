using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FizzBuzzApp;
using System.IO;
using System.Reflection;

namespace FizzBuzzTest
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void Should_Return_Fizz()
        {
            var fizzBuzz = new FizzBuzz();
            int validInt = 3;
            int invalidInt = 5;

            bool validResult = fizzBuzz.Fizz(validInt);
            bool invalidResult = fizzBuzz.Fizz(invalidInt);

            Assert.AreEqual(true, validResult);
            Assert.AreEqual(false, invalidResult);
        }
        [TestMethod]
        public void Should_Return_Buzz()
        {
            var fizzBuzz = new FizzBuzz();
            int validInt = 5;
            int invalidInt = 3;

            bool validResult = fizzBuzz.Buzz(validInt);
            bool invalidResult = fizzBuzz.Buzz(invalidInt);

            Assert.AreEqual(true, validResult);
            Assert.AreEqual(false, invalidResult);
        }
        [TestMethod]
        public void Should_Return_Universal_Answer()
        {
            var fizzBuzz = new FizzBuzz();
            int validInt = 42;
            int invalidInt = 5;

            bool validResult = fizzBuzz.UniversalAnswer(validInt);
            bool invalidResult = fizzBuzz.UniversalAnswer(invalidInt);

            Assert.AreEqual(true, validResult);
            Assert.AreEqual(false, invalidResult);
        }
        [TestMethod]
        public void Test_Run ()
        {
            FizzBuzz fizzbuzz = new FizzBuzz();
            var directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var path = string.Format("{0}\\{1}", directory, "correctFizzBuzzOutput_44.txt");
            var correctOutput = File.ReadAllText(path);
            var fizbuzzNumber = 44;
            using (var stringwriter = new StringWriter())
            {
                Console.SetOut(stringwriter);
                fizzbuzz.Run(fizbuzzNumber);
                Assert.AreEqual(correctOutput, stringwriter.ToString());
            };
        }
    }
}
