using System;
using BerlinClockGenerator;
using BerlinClockGenerator.RowGenerators;
using NUnit.Framework;
using Rhino.Mocks;

namespace BerlinClockUnitTests
{
    [TestFixture]
    public class BerlinClockUnitTests
    {
        
        [Test]
        public void ShouldGenerateInCorrectFormat()
        {
            const string expectedResult = "Y\nAAAA\nBBBB\nCCCCCCCCCCC\nDDDD";
            var topFirstRow = MockRepository.GenerateStub<IRowGenerator>();
            var topSecondRow = MockRepository.GenerateStub<IRowGenerator>();
            var bottomFirstRow = MockRepository.GenerateStub<IRowGenerator>();
            var bottomSecondRow = MockRepository.GenerateStub<IRowGenerator>();
            var yellowLampGen = MockRepository.GenerateStub<IRowGenerator>();

            topFirstRow.Expect(x => x.Generate(0)).Return("AAAA");
            topSecondRow.Expect(x => x.Generate(0)).Return("BBBB");
            bottomFirstRow.Expect(x => x.Generate(0)).Return("CCCCCCCCCCC");
            bottomSecondRow.Expect(x => x.Generate(0)).Return("DDDD");
            yellowLampGen.Expect(x => x.Generate(0)).Return("Y");
             
            var clock = new BerlinClock(topFirstRow, topSecondRow, bottomFirstRow, bottomSecondRow, yellowLampGen);
            var result = clock.Generate(0, 0, 0);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void ShouldConvertDateTimeToCorrectFormat()
        {
            const string expectedResult = "Y\nAAAA\nBBBB\nCCCCCCCCCCC\nDDDD";
            var topFirstRow = MockRepository.GenerateStub<IRowGenerator>();
            var topSecondRow = MockRepository.GenerateStub<IRowGenerator>();
            var bottomFirstRow = MockRepository.GenerateStub<IRowGenerator>();
            var bottomSecondRow = MockRepository.GenerateStub<IRowGenerator>();
            var yellowLampGen = MockRepository.GenerateStub<IRowGenerator>();

            topFirstRow.Expect(x => x.Generate(0)).Return("AAAA");
            topSecondRow.Expect(x => x.Generate(0)).Return("BBBB");
            bottomFirstRow.Expect(x => x.Generate(0)).Return("CCCCCCCCCCC");
            bottomSecondRow.Expect(x => x.Generate(0)).Return("DDDD");
            yellowLampGen.Expect(x => x.Generate(0)).Return("Y");
             
            var clock = new BerlinClock(topFirstRow, topSecondRow, bottomFirstRow, bottomSecondRow, yellowLampGen);
            var result = clock.Generate(new DateTime(1,1,1,0,0,0));
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}