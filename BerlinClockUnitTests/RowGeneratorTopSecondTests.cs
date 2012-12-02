using BerlinClockGenerator.RowGenerators;
using NUnit.Framework;

namespace BerlinClockUnitTests
{
    [TestFixture]
    public class RowGeneratorTopSecondTests
    {
        [TestCase(24,20,"RRRR")]
        [TestCase(13,10,"RRRO")]
        [TestCase(0,0,"OOOO")]
        public void GenerateCorrectZeroHour(int hour, int adjustment, string expectedResult)
        {
            var hourGenerator = new RowGeneratorTopSecond();
            var adjustedValue = hour - adjustment;
            var result = hourGenerator.Generate(adjustedValue);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}