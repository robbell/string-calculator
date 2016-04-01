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

            return calculator.Add(input);
        }

        [Test]
        public void TwoNumbersSeparatedByCommaAreAddedTogether()
        {
            var calculator = new StringCalculator();

            var result = calculator.Add("2,3");

            Assert.That(result, Is.EqualTo(5));
        }
    }

    public class StringCalculator
    {
        public int Add(string number)
        {
            if (string.IsNullOrEmpty(number)) return 0;

            var parts = number.Split(',');

            return parts.Length == 1 ? int.Parse(number) : int.Parse(parts[0]) + int.Parse(parts[1]);
        }
    }
}
