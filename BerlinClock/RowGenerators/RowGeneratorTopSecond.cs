using System;

namespace BerlinClockGenerator.RowGenerators
{
    public class RowGeneratorTopSecond : RowGenerator
    {        

        public override string Generate(int minutes)
        {
            return String.Format("{3}{2}{1}{0}", Smaller(minutes, 4),Smaller(minutes, 3),Smaller(minutes, 2),Smaller(minutes, 1));            
        }
    }
}