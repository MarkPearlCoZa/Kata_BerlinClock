using System;
using System.Collections.Generic;
using BerlinClockGenerator.RowGenerators;

namespace BerlinClockGenerator
{
    public class BerlinClock
    {
        private readonly IRowGenerator _topFirstRow;
        private readonly IRowGenerator _topSecondRow;
        private readonly IRowGenerator _bottomFirstRow;
        private readonly IRowGenerator _bottomSecondRow;
        private readonly IRowGenerator _lampGenerator;
        private readonly ValueBiggestFit _hourBiggestFit;
        private readonly ValueBiggestFit _minuteBiggestFit;

        public BerlinClock() : this(
            new RowGeneratorTopFirst(), 
            new RowGeneratorTopSecond(), 
            new RowGeneratorBottomFirst(), 
            new RowGeneratorBottomSecond(), 
            new RowGeneratorYellowLamp())
        {
        }

        public BerlinClock(IRowGenerator topFirstRow, IRowGenerator topSecondRow, IRowGenerator bottomFirstRow, IRowGenerator bottomSecondRow, IRowGenerator lampGenerator)
        {
            _topFirstRow = topFirstRow;
            _topSecondRow = topSecondRow;
            _bottomFirstRow = bottomFirstRow;
            _bottomSecondRow = bottomSecondRow;
            _lampGenerator = lampGenerator;
            _hourBiggestFit = new ValueBiggestFit(new List<int>{5, 10, 15, 20});
            _minuteBiggestFit = new ValueBiggestFit(new List<int>{5, 10, 15, 20, 25, 30, 35, 40, 35, 50 ,55});
        }

        public string Generate(DateTime timeOfDay)
        {
            return Generate(timeOfDay.Hour, timeOfDay.Minute, timeOfDay.Second);
        }      

        public string Generate(int hour, int minute, int second)
        {
            int hoursFirstRow = hour;
            int hoursSecondRow = hour - _hourBiggestFit.GetFit(hour);

            int minutesFirstRow = minute;
            int minutesSecondRow = minute - _minuteBiggestFit.GetFit(minute);

            return string.Format("{0}\n{1}\n{2}\n{3}\n{4}", _lampGenerator.Generate(second), _topFirstRow.Generate(hoursFirstRow), _topSecondRow.Generate(hoursSecondRow ), _bottomFirstRow.Generate(minutesFirstRow), _bottomSecondRow.Generate(minutesSecondRow));
        }
    }
}
