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

        [Test]
        public void NumberStringReturnsIntegerEquivalent()
        {
            var calculator = new StringCalculator();

            var result = calculator.Add("2");

            Assert.That(result, Is.EqualTo(2));
        }
    }

    public class StringCalculator
    {
        public int Add(string number)
        {
            if(String.IsNullOrEmpty(number)) return 0;

            return int.Parse(number);
        }
    }
}
