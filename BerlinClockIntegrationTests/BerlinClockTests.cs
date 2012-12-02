using BerlinClockGenerator;
using BerlinClockGenerator.RowGenerators;
using NUnit.Framework;

namespace BerlinClockIntegrationTests
{
    [TestFixture]
    public class BerlinClockTests
    {
        [TestCase(0,0,0,"Y\nOOOO\nOOOO\nOOOOOOOOOOO\nOOOO")]
        [TestCase(13,17,1,"O\nRROO\nRRRO\nYYROOOOOOOO\nYYOO")]
        [TestCase(23,59,59,"O\nRRRR\nRRRO\nYYRYYRYYRYY\nYYYY")]
        [TestCase(24,0,0,"Y\nRRRR\nRRRR\nOOOOOOOOOOO\nOOOO")]
        public void ShouldReturnTheRightValue(int hours, int minutes, int seconds, string expectedResult)
        {
            var topFirstRow = new RowGeneratorTopFirst();
            var topSecondRow = new RowGeneratorTopSecond();
            var bottomFirstRow = new RowGeneratorBottomFirst();
            var bottomSecondRow = new RowGeneratorBottomSecond();
            var yellowLampGen = new RowGeneratorYellowLamp();

            var clock = new BerlinClock(topFirstRow, topSecondRow, bottomFirstRow, bottomSecondRow, yellowLampGen);
            var result = clock.Generate(hours, minutes, seconds);
            Assert.That(result, Is.EqualTo(expectedResult));

        }
    }
}