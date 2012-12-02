using BerlinClockGenerator.RowGenerators;
using NUnit.Framework;

namespace BerlinClockUnitTests
{
    [TestFixture]
    public class RowGeneratorBottomwSecondTests
    {
        [TestCase(0,0,"OOOO")]
        [TestCase(17,15,"YYOO")]
        [TestCase(59,55,"YYYY")]
        public void ShouldGenerateCorrectResult(int value,int adjustment, string expectedResult)
        {
            var generator = new RowGeneratorBottomSecond();
            var adjustedValue = value - adjustment;
            var result = generator.Generate(adjustedValue);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}