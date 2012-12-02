using BerlinClockGenerator.RowGenerators;
using NUnit.Framework;

namespace BerlinClockUnitTests
{
    [TestFixture]
    public class YellowLampGeneratorTests
    {
        [TestCase(0,"Y")]
        [TestCase(1,"O")]
        [TestCase(2,"Y")]
        [TestCase(3,"O")]
        public void ShouldGenerateTheCorrectOutput(int value, string expectedValue)
        {
            var generator = new RowGeneratorYellowLamp();
            var result = generator.Generate(value);
            Assert.That(result, Is.EqualTo(expectedValue));
        }

    }
}