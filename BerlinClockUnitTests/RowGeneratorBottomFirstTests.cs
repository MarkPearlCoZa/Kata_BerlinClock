using BerlinClockGenerator.RowGenerators;
using NUnit.Framework;

namespace BerlinClockUnitTests
{
    [TestFixture]
    public class RowGeneratorBottomFirstTests
    {
        [TestCase(0,"OOOOOOOOOOO")]
        [TestCase(17,"YYROOOOOOOO")]
        [TestCase(59,"YYRYYRYYRYY")]
        public void ShouldGenerateExpectedResult(int value, string expectedResult)
        {
            var generator = new RowGeneratorBottomFirst();
            var result = generator.Generate(value);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}