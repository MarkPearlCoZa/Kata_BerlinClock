using System.Collections.Generic;
using BerlinClockGenerator;
using NUnit.Framework;

namespace BerlinClockUnitTests
{
    [TestFixture]
    public class ValueBiggestFitTests
    {
        [TestCase(9,5)]
        [TestCase(15,10)]
        [TestCase(19,15)]
        [TestCase(25,20)]
        public void ShouldReturnTheCorrectBiggestFit(int value, int expectedValue)
        {
            var calculator = new ValueBiggestFit(new List<int>
                {
                    5, 10, 15, 20
                });

            var result = calculator.GetFit(value);
            Assert.That(result, Is.EqualTo(expectedValue));


        }
    }
}