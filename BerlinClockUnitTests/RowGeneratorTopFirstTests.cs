using BerlinClockGenerator.RowGenerators;
using NUnit.Framework;

namespace BerlinClockUnitTests
{
    [TestFixture]
    public class RowGeneratorTopFirstTests
    {
        [TestCase(0,"OOOO")]
        [TestCase(9,"ROOO")]
        [TestCase(13,"RROO")]
        [TestCase(24,"RRRR")]
        public void GenerateCorrectZeroHour(int hour, string expectedResult)
        {
            var hourGenerator = new RowGeneratorTopFirst();
            var result = hourGenerator.Generate(hour);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}