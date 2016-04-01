using System;
using NUnit.Framework;

namespace StringCalculator.Tests
{
    [TestFixture]
    public class StringCalculatorTest
    {
        [Test]
        public void EmptyStringReturnsZero()
        {
            var calculator = new StringCalculator();

            var result = calculator.Add(String.Empty);

            Assert.That(result, Is.EqualTo(0));
        }

        [TestCase("2", ExpectedResult = 2)]
        [TestCase("5", ExpectedResult = 5)]
        [TestCase("23", ExpectedResult = 23)]
        public int NumberStringReturnsIntegerEquivalent(string input)
        {
            var calculator = new StringCalculator();

            var result = calculator.Add(input);

            return result;
        }
    }

    public class StringCalculator
    {
        public int Add(string number)
        {
            if (String.IsNullOrEmpty(number)) return 0;

            return int.Parse(number);
        }
    }
}
